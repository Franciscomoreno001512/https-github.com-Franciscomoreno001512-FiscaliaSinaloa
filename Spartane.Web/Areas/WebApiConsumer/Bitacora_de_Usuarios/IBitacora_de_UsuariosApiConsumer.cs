using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Data;
using Spartane.Web.Areas.WebApiConsumer.ResponseHelpers;

namespace Spartane.Web.Areas.WebApiConsumer.Bitacora_de_Usuarios
{
    public interface IBitacora_de_UsuariosApiConsumer
    {
        void SetAuthHeader(string token);
        Int32 SelCount();
        ApiResponse<IList<Spartane.Core.Domain.Bitacora_de_Usuarios.Bitacora_de_Usuarios>> SelAll(Boolean ConRelaciones);
        ApiResponse<IList<Spartane.Core.Domain.Bitacora_de_Usuarios.Bitacora_de_Usuarios>> SelAllComplete(Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.Bitacora_de_Usuarios.Bitacora_de_Usuarios> GetByKey(int Key, Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.Bitacora_de_Usuarios.Bitacora_de_UsuariosPagingModel> GetByKeyComplete(int Key);
        ApiResponse<bool> Delete(int Key, Spartane.Core.Domain.User.GlobalData Bitacora_de_UsuariosInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int32> Insert(Spartane.Core.Domain.Bitacora_de_Usuarios.Bitacora_de_Usuarios entity, Spartane.Core.Domain.User.GlobalData Bitacora_de_UsuariosInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int32> Update(Spartane.Core.Domain.Bitacora_de_Usuarios.Bitacora_de_Usuarios entity, Spartane.Core.Domain.User.GlobalData Bitacora_de_UsuariosInformation, DataLayerFieldsBitacora DataReference);

        ApiResponse<IList<Spartane.Core.Domain.Bitacora_de_Usuarios.Bitacora_de_Usuarios>> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        ApiResponse<IList<Spartane.Core.Domain.Bitacora_de_Usuarios.Bitacora_de_Usuarios>> SelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.Bitacora_de_Usuarios.Bitacora_de_Usuarios>> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<Spartane.Core.Domain.Bitacora_de_Usuarios.Bitacora_de_UsuariosPagingModel> ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.Bitacora_de_Usuarios.Bitacora_de_Usuarios>> ListaSelAll(Boolean ConRelaciones, string Where);
		ApiResponse<int> GenerateID();
		ApiResponse<int> Update_Datos_Generales(Spartane.Core.Domain.Bitacora_de_Usuarios.Bitacora_de_Usuarios_Datos_Generales entity);
		ApiResponse<Spartane.Core.Domain.Bitacora_de_Usuarios.Bitacora_de_Usuarios_Datos_Generales> Get_Datos_Generales(string Key);


    }
}

