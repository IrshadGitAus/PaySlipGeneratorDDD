using PaySlipGenerator.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilities.Exceptions;

namespace PaySlipGenerator.Core.Services.Transformers
{
    public class TransformerFactory : ITransformerFactory
    {
        public ITransformer FetchTransformer(FileExtensionType fileExtensionType)
        {
            switch(fileExtensionType)
            {
                case FileExtensionType.CSV:
                    return new CSVTransformer();
                case FileExtensionType.DAT:
                    return new DATTransformer();
                default:
                    throw new FileTypeNotSupportedException();
            }

        }
    }
}
