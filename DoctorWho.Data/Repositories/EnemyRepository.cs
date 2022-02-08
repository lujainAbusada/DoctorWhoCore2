﻿using System.Linq;
using DoctorWho.Data.DataModel;

namespace DoctorWho.Data.Repositories
{
    class EnemyRepository
    {
        private readonly DoctorWhoCoreDbContext _context = new DoctorWhoCoreDbContext();

        public void UpdateEnemyName(int enemyId, string newName)
        {
            var enemy = _context.Enemies.Where(a => a.EnemyId == enemyId).FirstOrDefault();
            enemy.EnemyName = newName;
            _context.SaveChanges();
        }

        public void UpdateEnemyDescription(int enemyId, string newDescription)
        {
            var enemy = _context.Enemies.Where(a => a.EnemyId == enemyId).FirstOrDefault();
            enemy.Description = newDescription;
            _context.SaveChanges();
        }

        public void InsertEnemy(Enemy enemy)
        {
            _context.Enemies.Add(enemy);
            _context.SaveChanges();
        }

        public void DeleteEnemy(Enemy enemy)
        {
            _context.Enemies.Remove(enemy);
            _context.SaveChanges();
        }

        public Enemy getEnemy(int enemyid)
        {
            return _context.Enemies.Where(e => e.EnemyId == enemyid).FirstOrDefault();
        }
    }
}
