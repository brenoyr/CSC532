using MyGameLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fall2020_CSC403_Project;
using System.Windows.Forms;

#pragma warning disable 1591 // use this to disable comment warnings

namespace Fall2020_CSC403_Project.code {
	public class BattleCharacter : Character {
		public int Health { get; set; }
		public int MaxHealth { get; set; }
		public float strength;
		public int experience;
		public int MaxExperience { get; set; }
		public int level;


		public event Action<int> AttackEvent;

        public string name { get; set; }

        public BattleCharacter(string name, Vector2 initPos, Collider collider) : base(initPos, collider) {
		    MaxHealth = 20;
		    strength = 2;
		    experience = 0;
				MaxExperience = 100;
		    level = 1;
		    Health = MaxHealth;

            this.name = name;

            if (this.name.Equals("player"))
            {
				SaveModel.PlayerMaxHealth = 20;
                SaveModel.Strength = 2;
                SaveModel.Experience = 0;
				SaveModel.Level = 1;
                SaveModel.PlayerHealth = 20;


            }

        }

	public void OnAttack(int amount) {
	  AttackEvent((int)(amount * strength));
	}

  public void AlterHealth(int amount) {
			Health += amount;
            if (this.name.Equals("player"))
            {
				SaveModel.PlayerHealth += amount;
            }
        }

	public void AlterExperience(string enemyType) {
		switch (enemyType) {
			case "regular":
				experience += 50;
				StatisticsModel.TotalExperienceGained += 50;
				SaveModel.Experience += 50;
				break;

			case "boss":
				experience += 100;
				StatisticsModel.TotalExperienceGained += 100;
				SaveModel.Experience += 100;
				break;

			default:
				throw new ArgumentException("enemyType is either null of invalid");
		}		

		if (experience >= 100) {
			LevelUp();
		}
	}

	public void LevelUp() {
		MaxHealth += 10;
		SaveModel.PlayerMaxHealth += 10;
		// Health = MaxHealth;  // Commented this out because it is currently impossible to die
		SaveModel.PlayerHealth = MaxHealth;
		strength += 1;
		SaveModel.Strength += 1;
		level += 1;
		SaveModel.Level += 1;
		experience -= 100;
		SaveModel.Experience -= 100;

		StatisticsModel.TotalLevelsGained += 1;
		StatisticsModel.TotalHealthGained += 10;
		StatisticsModel.TotalStrengthGained += 1;

		MessageBox.Show("Leveled Up!\n\nMax Health +10\nStrength + 1");

    }

  // Function set dead character's health to 0
  public void Die()
  {
      Health = 0;
  }
  }
}
