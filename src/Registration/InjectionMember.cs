﻿using System;
using Unity.Policy;

namespace Unity.Registration
{
    /// <summary>
    /// Base class for objects that can be used to configure what
    /// class members get injected by the container.
    /// </summary>
    public abstract class InjectionMember
    {
        /// <summary>
        /// Allows injection member to inject necessary policies into registration
        /// </summary>
        /// <param name="registeredType">Registration type</param>
        /// <param name="name">Registration naem</param>
        /// <param name="implementationType">Type of the implementation</param>
        /// <param name="set">Set where policies are kept</param>
        public virtual void AddPolicies(Type registeredType, string name, Type implementationType, IPolicySet set)
        {
        }
    }
}
