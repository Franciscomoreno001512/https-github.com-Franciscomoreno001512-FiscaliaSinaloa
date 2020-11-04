using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Data;
using Spartane.Web.Areas.WebApiConsumer.ResponseHelpers;

namespace Spartane.Web.Areas.WebApiConsumer.Especialidad
{
    public interface IEspecialidadApiConsumer
    {
        void SetAuthHeader(string token);
        Int32 SelCount();
        ApiResponse<IList<Spartane.Core.Domain.Especialidad.Especialidad>> SelAll(Boolean ConRelaciones);
        ApiResponse<IList<Spartane.Core.Domain.Especialidad.Especialidad>> SelAllComplete(Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.Especialidad.Especialidad> GetByKey(int Key, Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.Especialidad.EspecialidadPagingModel> GetByKeyComplete(int Key);
        ApiResponse<bool> Delete(int Key, Spartane.Core.Domain.User.GlobalData EspecialidadInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int32> Insert(Spartane.Core.Domain.Especialidad.Especialidad entity, Spartane.Core.Domain.User.GlobalData EspecialidadInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int32> Update(Spartane.Core.Domain.Especialidad.Especialidad entity, Spartane.Core.Domain.User.GlobalData EspecialidadInformation, DataLayerFieldsBitacora DataReference);

        ApiResponse<IList<Spartane.Core.Domain.Especialidad.Especialidad>> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        ApiResponse<IList<Spartane.Core.Domain.Especialidad.Especialidad>> SelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.Especialidad.Especialidad>> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<Spartane.Core.Domain.Especialidad.EspecialidadPagingModel> ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.Especialidad.Especialidad>> ListaSelAll(Boolean ConRelaciones, string Where);
		ApiResponse<int> GenerateID();
		ApiResponse<int> Update_Datos_Generales(Spartane.Core.Domain.Especialidad.Especialidad_Datos_Generales entity);
		ApiResponse<Spartane.Core.Domain.Especialidad.Especialidad_Datos_Generales> Get_Datos_Generales(string Key);


    }
}

