using System;
using System.Collections.Generic;
using System.Linq;
using JsonSubTypes;
using Newtonsoft.Json;

namespace Aptacode.Expressions.Json
{
    public class ExpressionsSubTypes
    {
        private readonly Dictionary<Type, HashSet<(Type, Type, Type)>> _subTypes = new Dictionary<Type, HashSet<(Type, Type, Type)>>();

        public ExpressionsSubTypes Add<T>()
        {
            var subType = typeof(T);

            var expressionType = subType
                .GetInterfaces().FirstOrDefault(i => i.IsGenericType && i.GetGenericTypeDefinition() == typeof(IExpression<,>));
            
            if(expressionType == default)
                return this;
            
            var expressionArguments = expressionType.GetGenericArguments().ToArray();

            if (!_subTypes.TryGetValue(expressionType, out var subTypes))
            {
                subTypes = new HashSet<(Type, Type, Type)>();
                _subTypes[expressionType] = subTypes;
            }
            subTypes.Add((subType, expressionArguments[0], expressionArguments[1]));

            return this;
        }

        public JsonSerializerSettings AddSubTypes(JsonSerializerSettings settings)
        {
            foreach (var kvp in _subTypes)
            {
                var builder = JsonSubtypesConverterBuilder.Of(kvp.Key, "Exp");
                foreach (var subtype in kvp.Value)
                {
                    builder.RegisterSubtype(subtype.Item1, GetName(subtype));
                }

                settings.Converters.Add(builder
                    .SerializeDiscriminatorProperty(true)
                    .Build());
            }


            return settings;
        }

        public string GetName((Type, Type, Type) subType)
        {
            return $"{subType.Item1.Name}<{subType.Item2.Name},{subType.Item3.Name}>";
        }
    }
}