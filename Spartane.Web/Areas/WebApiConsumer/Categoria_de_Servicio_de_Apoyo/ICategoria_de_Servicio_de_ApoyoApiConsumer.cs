using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Data;
using Spartane.Web.Areas.WebApiConsumer.ResponseHelpers;

namespace Spartane.Web.Areas.WebApiConsumer.Categoria_de_Servicio_de_Apoyo
{
    public interface ICategoria_de_Servicio_de_ApoyoApiConsumer
    {
        void SetAuthHeader(string token);
        Int32 SelCount();
        ApiResponse<IList<Spartane.Core.Domain.Categoria_de_Servicio_de_Apoyo.Categoria_de_Servicio_de_Apoyo>> SelAll(Boolean ConRelaciones);
        ApiResponse<IList<Spartane.Core.Domain.Categoria_de_Servicio_de_Apoyo.Categoria_de_Servicio_de_Apoyo>> SelAllComplete(Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.Categoria_de_Servicio_de_Apoyo.Categoria_de_Servicio_de_Apoyo> GetByKey(short Key, Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.Categoria_de_Servicio_de_Apoyo.Categoria_de_Servicio_de_ApoyoPagingModel> GetByKeyComplete(short Key);
        ApiResponse<bool> Delete(short Key, Spartane.Core.Domain.User.GlobalData Categoria_de_Servicio_de_ApoyoInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int16> Insert(Spartane.Core.Domain.Categoria_de_Servicio_de_Apoyo.Categoria_de_Servicio_de_Apoyo entity, Spartane.Core.Domain.User.GlobalData Categoria_de_Servicio_de_ApoyoInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int16> Update(Spartane.Core.Domain.Categoria_de_Servicio_de_Apoyo.Categoria_de_Servicio_de_Apoyo entity, Spartane.Core.Domain.User.GlobalData Categoria_de_Servicio_de_ApoyoInformation, DataLayerFieldsBitacora DataReference);

        ApiResponse<IList<Spartane.Core.Domain.Categoria_de_Servicio_de_Apoyo.Categoria_de_Servicio_de_Apoyo>> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        ApiResponse<IList<Spartane.Core.Domain.Categoria_de_Servicio_de_Apoyo.Categoria_de_Servicio_de_Apoyo>> SelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.Categoria_de_Servicio_de_Apoyo.Categoria_de_Servicio_de_Apoyo>> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<Spartane.Core.Domain.Categoria_de_Servicio_de_Apoyo.Categoria_de_Servicio_de_ApoyoPagingModel> ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.Categoria_de_Servicio_de_Apoyo.Categoria_de_Servicio_de_Apoyo>> ListaSelAll(Boolean ConRelaciones, string Where);
		ApiResponse<short> GenerateID();
		ApiResponse<short> Update_Datos_Generales(Spartane.Core.Domain.Categoria_de_Servicio_de_Apoyo.Categoria_de_Servicio_de_Apoyo_Datos_Generales entity);
		ApiResponse<Spartane.Core.Domain.Categoria_de_Servicio_de_Apoyo.Categoria_de_Servicio_de_Apoyo_Datos_Generales> Get_Datos_Generales(string Key);


    }
}

