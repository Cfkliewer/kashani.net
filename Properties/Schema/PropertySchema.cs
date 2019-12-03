using System;
using System.Collections.Generic;
using System.Text;
using GraphQL;
using GraphQL.Types;

namespace Properties.Schema
{
    public class PropertySchema : GraphQL.Types.Schema 
    {
        public PropertySchema(PropertyQuery query, IDependencyResolver resolver)
        {
            Query = query;
            DependencyResolver = resolver;
        }
    }
}
