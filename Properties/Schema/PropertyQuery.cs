using System;
using System.Collections.Generic;
using System.Text;
using GraphQL.Types;
using Properties.Service;

namespace Properties.Schema
{
    public class PropertyQuery : ObjectGraphType<object>
    {
        public PropertyQuery(IPropertyService properties)
        {
            Field<ListGraphType<PropertyType>>(
                "properties",
                resolve: context => properties.getAllPropertiesAsync()
            );

            Field<PropertyType>(
                "propertyById",
                arguments: new QueryArguments(new QueryArgument<NonNullGraphType<StringGraphType>> { Name = "mlsId" }),
                resolve: context => properties.getPropertyById(context.GetArgument<string>("mlsId"))
            );
        }

    }
}
