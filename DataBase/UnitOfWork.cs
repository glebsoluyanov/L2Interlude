﻿using System;
using DataBase.Interfaces;

namespace DataBase
{
    public class UnitOfWork : IUnitOfWork
    {
        public IAccountRepository Accounts { get; }
        public ICharacterRepository Characters { get; }
        public ISpawnListRepository SpawnList { get; }
        public IRaidBossSpawnListRepository RaidBossSpawnList { get; }
        public IUserItemRepository UserItems { get; }
        public ISkillTreeRepository SkillTree { get; }
        public ICharacterSkillRepository CharacterSkill { get; }
        public IShortCutRepository ShortCut { get; }

        public UnitOfWork(
            IAccountRepository accountRepository, 
            ICharacterRepository characterRepository,
            ISpawnListRepository spawnListRepository,
            IUserItemRepository userItemRepository,
            ISkillTreeRepository skillTreeRepository,
            ICharacterSkillRepository characterSkillRepository,
            IShortCutRepository shortCutRepository,
            IRaidBossSpawnListRepository raidBossSpawnListRepository
            )
        {
            Accounts = accountRepository;
            Characters = characterRepository;
            SpawnList = spawnListRepository;
            UserItems = userItemRepository;
            SkillTree = skillTreeRepository;
            CharacterSkill = characterSkillRepository;
            ShortCut = shortCutRepository;
            RaidBossSpawnList = raidBossSpawnListRepository;
        }
    }
}