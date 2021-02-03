using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Data;
using Spartane.Web.Areas.WebApiConsumer.ResponseHelpers;

namespace Spartane.Web.Areas.WebApiConsumer.Formulacion_de_Imputacion
{
    public interface IFormulacion_de_ImputacionApiConsumer
    {
        void SetAuthHeader(string token);
        Int32 SelCount();
        ApiResponse<IList<Spartane.Core.Domain.Formulacion_de_Imputacion.Formulacion_de_Imputacion>> SelAll(Boolean ConRelaciones);
        ApiResponse<IList<Spartane.Core.Domain.Formulacion_de_Imputacion.Formulacion_de_Imputacion>> SelAllComplete(Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.Formulacion_de_Imputacion.Formulacion_de_Imputacion> GetByKey(int Key, Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.Formulacion_de_Imputacion.Formulacion_de_ImputacionPagingModel> GetByKeyComplete(int Key);
        ApiResponse<bool> Delete(int Key, Spartane.Core.Domain.User.GlobalData Formulacion_de_ImputacionInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int32> Insert(Spartane.Core.Domain.Formulacion_de_Imputacion.Formulacion_de_Imputacion entity, Spartane.Core.Domain.User.GlobalData Formulacion_de_ImputacionInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int32> Update(Spartane.Core.Domain.Formulacion_de_Imputacion.Formulacion_de_Imputacion entity, Spartane.Core.Domain.User.GlobalData Formulacion_de_ImputacionInformation, DataLayerFieldsBitacora DataReference);

        ApiResponse<IList<Spartane.Core.Domain.Formulacion_de_Imputacion.Formulacion_de_Imputacion>> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        ApiResponse<IList<Spartane.Core.Domain.Formulacion_de_Imputacion.Formulacion_de_Imputacion>> SelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.Formulacion_de_Imputacion.Formulacion_de_Imputacion>> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<Spartane.Core.Domain.Formulacion_de_Imputacion.Formulacion_de_ImputacionPagingModel> ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.Formulacion_de_Imputacion.Formulacion_de_Imputacion>> ListaSelAll(Boolean ConRelaciones, string Where);
		ApiResponse<int> GenerateID();
		ApiResponse<int> Update_Datos_Generales(Spartane.Core.Domain.Formulacion_de_Imputacion.Formulacion_de_Imputacion_Datos_Generales entity);
		ApiResponse<Spartane.Core.Domain.Formulacion_de_Imputacion.Formulacion_de_Imputacion_Datos_Generales> Get_Datos_Generales(string Key);


    }
}

