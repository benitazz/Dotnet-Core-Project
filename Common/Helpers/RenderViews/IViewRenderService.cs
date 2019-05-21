using System.Threading.Tasks;

namespace MedicalBilingMicroservice.Common.Helpers.RenderViews {
    public interface IViewRenderService {
        Task<string> RenderToStringAsync (string viewName, object model);
        
    }
}