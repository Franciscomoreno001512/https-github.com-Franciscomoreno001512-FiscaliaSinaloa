using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Data;
using Spartane.Web.Areas.WebApiConsumer.ResponseHelpers;

namespace Spartane.Web.Areas.WebApiConsumer.Formato_de_Seguimiento
{
    public interface IFormato_de_SeguimientoApiConsumer
    {
        void SetAuthHeader(string token);
        Int32 SelCount();
        ApiResponse<IList<Spartane.Core.Domain.Formato_de_Seguimiento.Formato_de_Seguimiento>> SelAll(Boolean ConRelaciones);
        ApiResponse<IList<Spartane.Core.Domain.Formato_de_Seguimiento.Formato_de_Seguimiento>> SelAllComplete(Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.Formato_de_Seguimiento.Formato_de_Seguimiento> GetByKey(int Key, Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.Formato_de_Seguimiento.Formato_de_SeguimientoPagingModel> GetByKeyComplete(int Key);
        ApiResponse<bool> Delete(int Key, Spartane.Core.Domain.User.GlobalData Formato_de_SeguimientoInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int32> Insert(Spartane.Core.Domain.Formato_de_Seguimiento.Formato_de_Seguimiento entity, Spartane.Core.Domain.User.GlobalData Formato_de_SeguimientoInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int32> Update(Spartane.Core.Domain.Formato_de_Seguimiento.Formato_de_Seguimiento entity, Spartane.Core.Domain.User.GlobalData Formato_de_SeguimientoInformation, DataLayerFieldsBitacora DataReference);

        ApiResponse<IList<Spartane.Core.Domain.Formato_de_Seguimiento.Formato_de_Seguimiento>> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        ApiResponse<IList<Spartane.Core.Domain.Formato_de_Seguimiento.Formato_de_Seguimiento>> SelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.Formato_de_Seguimiento.Formato_de_Seguimiento>> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<Spartane.Core.Domain.Formato_de_Seguimiento.Formato_de_SeguimientoPagingModel> ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.Formato_de_Seguimiento.Formato_de_Seguimiento>> ListaSelAll(Boolean ConRelaciones, string Where);
		ApiResponse<int> GenerateID();
		ApiResponse<int> Update_Datos_Generales(Spartane.Core.Domain.Formato_de_Seguimiento.Formato_de_Seguimiento_Datos_Generales entity);
		ApiResponse<Spartane.Core.Domain.Formato_de_Seguimiento.Formato_de_Seguimiento_Datos_Generales> Get_Datos_Generales(string Key);


    }
}

