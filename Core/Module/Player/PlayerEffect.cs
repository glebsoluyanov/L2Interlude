﻿using System.Collections.Concurrent;
using System.Collections.Generic;
using Core.Module.SkillData;
using Core.Module.SkillData.Effects;
using Microsoft.Extensions.DependencyInjection;

namespace Core.Module.Player
{
    public class PlayerEffect
    {
        private readonly PlayerInstance _playerInstance;
        private readonly ConcurrentDictionary<string, SkillDataModel> _currentEffects;
        private readonly SkillDataInit _dataInit;
        private readonly EffectInit _effectInit;
        public PlayerEffect(PlayerInstance playerInstance)
        {
            _playerInstance = playerInstance;
            _currentEffects = new ConcurrentDictionary<string, SkillDataModel>();
            _dataInit = playerInstance.ServiceProvider.GetRequiredService<SkillDataInit>();
            _effectInit = playerInstance.ServiceProvider.GetRequiredService<EffectInit>();
        }

        public void AddEffect(Effect effect)
        {
            _currentEffects.TryAdd(effect.SkillDataModel.SkillName, effect.SkillDataModel);
        }

        public void RemoveEffect(Effect effect)
        {
            _currentEffects.TryRemove(effect.SkillDataModel.SkillName, out _);
        }

        public IEnumerable<SkillDataModel> GetEffects()
        {
            return _currentEffects.Values;
        }
    }
}