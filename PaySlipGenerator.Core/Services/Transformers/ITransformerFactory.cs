using PaySlipGenerator.Core.Model;

namespace PaySlipGenerator.Core.Services.Transformers
{
    public interface ITransformerFactory
    {
        ITransformer FetchTransformer(FileExtensionType fileExtensionType);
    }
}