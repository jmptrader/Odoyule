// Copyright 2011 Chris Patterson
// 
// Licensed under the Apache License, Version 2.0 (the "License"); you may not use 
// this file except in compliance with the License. You may obtain a copy of the 
// License at 
// 
//     http://www.apache.org/licenses/LICENSE-2.0 
// 
// Unless required by applicable law or agreed to in writing, software distributed 
// under the License is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR 
// CONDITIONS OF ANY KIND, either express or implied. See the License for the 
// specific language governing permissions and limitations under the License.
namespace OdoyuleRules.Models.SemanticModel.Conditions
{
    using System;

    /// <summary>
    /// A predicate condition is a very primitive version of a predicate that given an object
    /// returns true. There is no safety checking at this point. It is preferable to build
    /// out a property match node and then have a predicate on that match node instead of 
    /// referencing an object property directly since it might be null.
    /// </summary>
    /// <typeparam name="T">The fact type for the expression</typeparam>
    public class PredicateCondition<T> :
        RuleCondition<T>
    {
        readonly Func<T, bool> _predicate;

        public PredicateCondition(Func<T, bool> predicate)
        {
            _predicate = predicate;
        }

        public Func<T, bool> Predicate
        {
            get { return _predicate; }
        }
    }
}