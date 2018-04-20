using System;
using System.Collections.Generic;
using System.Text;
using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore.Query.Expressions;
using Microsoft.EntityFrameworkCore.Query.Sql;

namespace ExasolEF_NetCore.Query.Sql.Internal
{
    public class ExasolQuerySqlGenerator : DefaultQuerySqlGenerator
    {
        protected ExasolQuerySqlGenerator([NotNull] QuerySqlGeneratorDependencies dependencies, [NotNull] SelectExpression selectExpression) : base(dependencies, selectExpression)
        {
        }
    }
}
