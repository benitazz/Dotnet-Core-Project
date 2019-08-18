using System.Threading.Tasks;

namespace MedicalEngineMicroService.Common.Helpers.RenderViews {
    public interface IViewRenderService {
        Task<string> RenderToStringAsync (string viewName, object model);
        
    }
}