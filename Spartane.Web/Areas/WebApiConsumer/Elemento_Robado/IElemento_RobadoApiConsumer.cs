using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Data;
using Spartane.Web.Areas.WebApiConsumer.ResponseHelpers;

namespace Spartane.Web.Areas.WebApiConsumer.Elemento_Robado
{
    public interface IElemento_RobadoApiConsumer
    {
        void SetAuthHeader(string token);
        Int32 SelCount();
        ApiResponse<IList<Spartane.Core.Domain.Elemento_Robado.Elemento_Robado>> SelAll(Boolean ConRelaciones);
        ApiResponse<IList<Spartane.Core.Domain.Elemento_Robado.Elemento_Robado>> SelAllComplete(Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.Elemento_Robado.Elemento_Robado> GetByKey(int Key, Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.Elemento_Robado.Elemento_RobadoPagingModel> GetByKeyComplete(int Key);
        ApiResponse<bool> Delete(int Key, Spartane.Core.Domain.User.GlobalData Elemento_RobadoInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int32> Insert(Spartane.Core.Domain.Elemento_Robado.Elemento_Robado entity, Spartane.Core.Domain.User.GlobalData Elemento_RobadoInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int32> Update(Spartane.Core.Domain.Elemento_Robado.Elemento_Robado entity, Spartane.Core.Domain.User.GlobalData Elemento_RobadoInformation, DataLayerFieldsBitacora DataReference);

        ApiResponse<IList<Spartane.Core.Domain.Elemento_Robado.Elemento_Robado>> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        ApiResponse<IList<Spartane.Core.Domain.Elemento_Robado.Elemento_Robado>> SelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.Elemento_Robado.Elemento_Robado>> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<Spartane.Core.Domain.Elemento_Robado.Elemento_RobadoPagingModel> ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.Elemento_Robado.Elemento_Robado>> ListaSelAll(Boolean ConRelaciones, string Where);
		ApiResponse<int> GenerateID();
		ApiResponse<int> Update_Datos_Generales(Spartane.Core.Domain.Elemento_Robado.Elemento_Robado_Datos_Generales entity);
		ApiResponse<Spartane.Core.Domain.Elemento_Robado.Elemento_Robado_Datos_Generales> Get_Datos_Generales(string Key);


    }
}

