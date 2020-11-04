using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Data;
using Spartane.Web.Areas.WebApiConsumer.ResponseHelpers;

namespace Spartane.Web.Areas.WebApiConsumer.Rol_de_Diligencia
{
    public interface IRol_de_DiligenciaApiConsumer
    {
        void SetAuthHeader(string token);
        Int32 SelCount();
        ApiResponse<IList<Spartane.Core.Domain.Rol_de_Diligencia.Rol_de_Diligencia>> SelAll(Boolean ConRelaciones);
        ApiResponse<IList<Spartane.Core.Domain.Rol_de_Diligencia.Rol_de_Diligencia>> SelAllComplete(Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.Rol_de_Diligencia.Rol_de_Diligencia> GetByKey(short Key, Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.Rol_de_Diligencia.Rol_de_DiligenciaPagingModel> GetByKeyComplete(short Key);
        ApiResponse<bool> Delete(short Key, Spartane.Core.Domain.User.GlobalData Rol_de_DiligenciaInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int16> Insert(Spartane.Core.Domain.Rol_de_Diligencia.Rol_de_Diligencia entity, Spartane.Core.Domain.User.GlobalData Rol_de_DiligenciaInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int16> Update(Spartane.Core.Domain.Rol_de_Diligencia.Rol_de_Diligencia entity, Spartane.Core.Domain.User.GlobalData Rol_de_DiligenciaInformation, DataLayerFieldsBitacora DataReference);

        ApiResponse<IList<Spartane.Core.Domain.Rol_de_Diligencia.Rol_de_Diligencia>> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        ApiResponse<IList<Spartane.Core.Domain.Rol_de_Diligencia.Rol_de_Diligencia>> SelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.Rol_de_Diligencia.Rol_de_Diligencia>> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<Spartane.Core.Domain.Rol_de_Diligencia.Rol_de_DiligenciaPagingModel> ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.Rol_de_Diligencia.Rol_de_Diligencia>> ListaSelAll(Boolean ConRelaciones, string Where);
		ApiResponse<short> GenerateID();
		ApiResponse<short> Update_Datos_Generales(Spartane.Core.Domain.Rol_de_Diligencia.Rol_de_Diligencia_Datos_Generales entity);
		ApiResponse<Spartane.Core.Domain.Rol_de_Diligencia.Rol_de_Diligencia_Datos_Generales> Get_Datos_Generales(string Key);


    }
}

