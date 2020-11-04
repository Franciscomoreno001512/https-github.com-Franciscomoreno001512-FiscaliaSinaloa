using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Data;
using Spartane.Web.Areas.WebApiConsumer.ResponseHelpers;

namespace Spartane.Web.Areas.WebApiConsumer.Relacion_Unidad_Usuario
{
    public interface IRelacion_Unidad_UsuarioApiConsumer
    {
        void SetAuthHeader(string token);
        Int32 SelCount();
        ApiResponse<IList<Spartane.Core.Domain.Relacion_Unidad_Usuario.Relacion_Unidad_Usuario>> SelAll(Boolean ConRelaciones);
        ApiResponse<IList<Spartane.Core.Domain.Relacion_Unidad_Usuario.Relacion_Unidad_Usuario>> SelAllComplete(Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.Relacion_Unidad_Usuario.Relacion_Unidad_Usuario> GetByKey(int Key, Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.Relacion_Unidad_Usuario.Relacion_Unidad_UsuarioPagingModel> GetByKeyComplete(int Key);
        ApiResponse<bool> Delete(int Key, Spartane.Core.Domain.User.GlobalData Relacion_Unidad_UsuarioInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int32> Insert(Spartane.Core.Domain.Relacion_Unidad_Usuario.Relacion_Unidad_Usuario entity, Spartane.Core.Domain.User.GlobalData Relacion_Unidad_UsuarioInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int32> Update(Spartane.Core.Domain.Relacion_Unidad_Usuario.Relacion_Unidad_Usuario entity, Spartane.Core.Domain.User.GlobalData Relacion_Unidad_UsuarioInformation, DataLayerFieldsBitacora DataReference);

        ApiResponse<IList<Spartane.Core.Domain.Relacion_Unidad_Usuario.Relacion_Unidad_Usuario>> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        ApiResponse<IList<Spartane.Core.Domain.Relacion_Unidad_Usuario.Relacion_Unidad_Usuario>> SelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.Relacion_Unidad_Usuario.Relacion_Unidad_Usuario>> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<Spartane.Core.Domain.Relacion_Unidad_Usuario.Relacion_Unidad_UsuarioPagingModel> ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.Relacion_Unidad_Usuario.Relacion_Unidad_Usuario>> ListaSelAll(Boolean ConRelaciones, string Where);
		ApiResponse<int> GenerateID();
		ApiResponse<int> Update_Datos_Generales(Spartane.Core.Domain.Relacion_Unidad_Usuario.Relacion_Unidad_Usuario_Datos_Generales entity);
		ApiResponse<Spartane.Core.Domain.Relacion_Unidad_Usuario.Relacion_Unidad_Usuario_Datos_Generales> Get_Datos_Generales(string Key);


    }
}

