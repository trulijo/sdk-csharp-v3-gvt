using System.Collections.Generic;
using Trulioo.Client.V3.Models.Errors;

namespace Trulioo.Client.V3.Models.Response
{
    /// <summary>
    /// A result from a particular datasource
    /// </summary>
    public class DatasourceResult
    {
        public string DatasourceStatus { get; set; }

        public string DatasourceName { get; set; }

        public IEnumerable<DatasourceField> DatasourceFields { get; set; }

        public IEnumerable<AppendedField> AppendedFields { get; set; }

        public IEnumerable<ServiceError> Errors { get; set; }

        public IEnumerable<string> FieldGroups { get; set; }
    }
}
