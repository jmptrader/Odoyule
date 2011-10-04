﻿// Copyright 2011 Chris Patterson
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
namespace OdoyuleRules.Models.RuntimeModel
{
    using System;

    public interface RuntimeModelVisitor
    {
        bool Visit(RulesEngine rulesEngine, Func<RuntimeModelVisitor, bool> next);

        bool Visit<T>(Node<T> node, Func<RuntimeModelVisitor, bool> next)
            where T : class;


        bool Visit<T>(AlphaNode<T> node, Func<RuntimeModelVisitor, bool> next)
            where T : class;

        bool Visit<TInput, TOutput>(ConvertNode<TInput, TOutput> node, Func<RuntimeModelVisitor, bool> next)
            where TInput : class, TOutput 
            where TOutput : class;

        bool Visit<T>(DelegateProductionNode<T> node, Func<RuntimeModelVisitor, bool> next)
            where T : class;
    }
}