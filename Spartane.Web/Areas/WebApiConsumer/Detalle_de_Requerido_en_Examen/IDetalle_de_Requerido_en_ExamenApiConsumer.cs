using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Data;
using Spartane.Web.Areas.WebApiConsumer.ResponseHelpers;

namespace Spartane.Web.Areas.WebApiConsumer.Detalle_de_Requerido_en_Examen
{
    public interface IDetalle_de_Requerido_en_ExamenApiConsumer
    {
        void SetAuthHeader(string token);
        Int32 SelCount();
        ApiResponse<IList<Spartane.Core.Domain.Detalle_de_Requerido_en_Examen.Detalle_de_Requerido_en_Examen>> SelAll(Boolean ConRelaciones);
        ApiResponse<IList<Spartane.Core.Domain.Detalle_de_Requerido_en_Examen.Detalle_de_Requerido_en_Examen>> SelAllComplete(Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.Detalle_de_Requerido_en_Examen.Detalle_de_Requerido_en_Examen> GetByKey(int Key, Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.Detalle_de_Requerido_en_Examen.Detalle_de_Requerido_en_ExamenPagingModel> GetByKeyComplete(int Key);
        ApiResponse<bool> Delete(int Key, Spartane.Core.Domain.User.GlobalData Detalle_de_Requerido_en_ExamenInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int32> Insert(Spartane.Core.Domain.Detalle_de_Requerido_en_Examen.Detalle_de_Requerido_en_Examen entity, Spartane.Core.Domain.User.GlobalData Detalle_de_Requerido_en_ExamenInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int32> Update(Spartane.Core.Domain.Detalle_de_Requerido_en_Examen.Detalle_de_Requerido_en_Examen entity, Spartane.Core.Domain.User.GlobalData Detalle_de_Requerido_en_ExamenInformation, DataLayerFieldsBitacora DataReference);

        ApiResponse<IList<Spartane.Core.Domain.Detalle_de_Requerido_en_Examen.Detalle_de_Requerido_en_Examen>> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        ApiResponse<IList<Spartane.Core.Domain.Detalle_de_Requerido_en_Examen.Detalle_de_Requerido_en_Examen>> SelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.Detalle_de_Requerido_en_Examen.Detalle_de_Requerido_en_Examen>> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<Spartane.Core.Domain.Detalle_de_Requerido_en_Examen.Detalle_de_Requerido_en_ExamenPagingModel> ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.Detalle_de_Requerido_en_Examen.Detalle_de_Requerido_en_Examen>> ListaSelAll(Boolean ConRelaciones, string Where);
		ApiResponse<int> GenerateID();
		ApiResponse<int> Update_Datos_Generales(Spartane.Core.Domain.Detalle_de_Requerido_en_Examen.Detalle_de_Requerido_en_Examen_Datos_Generales entity);
		ApiResponse<Spartane.Core.Domain.Detalle_de_Requerido_en_Examen.Detalle_de_Requerido_en_Examen_Datos_Generales> Get_Datos_Generales(string Key);


    }
}

