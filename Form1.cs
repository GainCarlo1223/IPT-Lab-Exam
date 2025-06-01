using System;
using System.Windows.Forms;
using ClassmatesRpgBattleSim.Models;

namespace ClassmatesRpgBattleSim
{
    public partial class Form1 : Form
    {
        private ClassFighter? player1;
        private ClassFighter? player2;
        private bool battleInProgress = false;

        public Form1()
        {
            InitializeComponent();
            // Initialize the health bars
            healthBarPlayer1.Value = 100;
            healthBarPlayer2.Value = 100;
        }

        private void BtnStartBattle_Click(object sender, EventArgs e)
        {
            try
            {
                if (battleInProgress)
                {
                    MessageBox.Show("A battle is already in progress!", "Battle Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Validate inputs
                if (string.IsNullOrWhiteSpace(txtPlayer1Name.Text) || string.IsNullOrWhiteSpace(txtPlayer2Name.Text))
                {
                    MessageBox.Show("Please enter names for both players!", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string? player1Type = cmbPlayer1Type.SelectedItem?.ToString();
                string? player2Type = cmbPlayer2Type.SelectedItem?.ToString();

                if (string.IsNullOrEmpty(player1Type) || string.IsNullOrEmpty(player2Type))
                {
                    MessageBox.Show("Please select character types for both players!", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Create fighters
                player1 = CreateFighter(txtPlayer1Name.Text, player1Type);
                player2 = CreateFighter(txtPlayer2Name.Text, player2Type);

                // Set initial health bar values
                healthBarPlayer1.Maximum = player1.MaxHealth;
                healthBarPlayer1.Value = player1.Health;
                healthBarPlayer2.Maximum = player2.MaxHealth;
                healthBarPlayer2.Value = player2.Health;

                // Start battle
                battleInProgress = true;
                btnStartBattle.Enabled = false;
                StartBattle();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                battleInProgress = false;
                btnStartBattle.Enabled = true;
            }
        }

        private ClassFighter CreateFighter(string name, string type)
        {
            return type switch
            {
                "CodeCrusher" => new CodeCrusher(name),
                "QuizMaster" => new QuizMaster(name),
                _ => throw new ArgumentException($"Unknown fighter type: {type}")
            };
        }

        private void StartBattle()
        {
            if (player1 == null || player2 == null)
            {
                MessageBox.Show("Players not properly initialized!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                battleInProgress = false;
                btnStartBattle.Enabled = true;
                return;
            }

            txtBattleLog.Clear();
            LogBattle("Battle started!");
            LogBattle($"{player1.Name} ({player1.GetType().Name}) vs {player2.Name} ({player2.GetType().Name})");
            LogBattle("----------------------------------------");

            var battleTimer = new System.Windows.Forms.Timer();
            battleTimer.Interval = 1000; // 1 second delay
            battleTimer.Tick += (sender, e) =>
            {
                // Player 1 attacks
                int damage1 = player1.Attack();
                bool player2Alive = player2.TakeDamage(damage1);
                LogBattle($"{player1.Name} attacks for {damage1} damage! {player2.Name} has {player2.Health} health remaining.");
                UpdateHealthUI();

                if (!player2Alive)
                {
                    EndBattle(player1);
                    battleTimer.Stop();
                    return;
                }

                // Player 2 attacks
                int damage2 = player2.Attack();
                bool player1Alive = player1.TakeDamage(damage2);
                LogBattle($"{player2.Name} attacks for {damage2} damage! {player1.Name} has {player1.Health} health remaining.");
                UpdateHealthUI();

                if (!player1Alive)
                {
                    EndBattle(player2);
                    battleTimer.Stop();
                    return;
                }
            };
            battleTimer.Start();
        }

        private void EndBattle(ClassFighter winner)
        {
            LogBattle("----------------------------------------");
            LogBattle($"{winner.Name} wins the battle!");
            battleInProgress = false;
            btnStartBattle.Enabled = true;
        }

        private void LogBattle(string message)
        {
            txtBattleLog.AppendText(message + Environment.NewLine);
            txtBattleLog.ScrollToCaret();
        }

        private void UpdateHealthUI()
        {
            if (player1 == null || player2 == null) return;

            lblPlayer1Health.Text = $"Health: {player1.Health} / {player1.MaxHealth}";
            healthBarPlayer1.Value = Math.Max(0, player1.Health);

            lblPlayer2Health.Text = $"Health: {player2.Health} / {player2.MaxHealth}";
            healthBarPlayer2.Value = Math.Max(0, player2.Health);
        }
    }
}