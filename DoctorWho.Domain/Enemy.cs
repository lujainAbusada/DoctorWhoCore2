using System;
using System.Collections.Generic;
using System.Text;

namespace DoctorWho.Domain
{
    public class Enemy
    {
        public Enemy()
        {
            EpisodeEnemies = new List<EpisodeEnemy>();
        }

        public int EnemyId { get; set; }
        public string EnemyName { get; set; }
        public string Description { get; set; }
        public List<EpisodeEnemy> EpisodeEnemies { get; set; }

        public void UpdateEnemyName(int enemyId, string newName)
        {
            EnemyName = newName;
        }
    }
}
