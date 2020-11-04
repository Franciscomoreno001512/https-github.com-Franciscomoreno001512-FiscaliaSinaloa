using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Data;
using Spartane.Web.Areas.WebApiConsumer.ResponseHelpers;

namespace Spartane.Web.Areas.WebApiConsumer.PasaTurnos
{
    public interface IPasaTurnosApiConsumer
    {
        void SetAuthHeader(string token);
        Int32 SelCount();
        ApiResponse<IList<Spartane.Core.Domain.PasaTurnos.PasaTurnos>> SelAll(Boolean ConRelaciones);
        ApiResponse<IList<Spartane.Core.Domain.PasaTurnos.PasaTurnos>> SelAllComplete(Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.PasaTurnos.PasaTurnos> GetByKey(int Key, Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.PasaTurnos.PasaTurnosPagingModel> GetByKeyComplete(int Key);
        ApiResponse<bool> Delete(int Key, Spartane.Core.Domain.User.GlobalData PasaTurnosInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int32> Insert(Spartane.Core.Domain.PasaTurnos.PasaTurnos entity, Spartane.Core.Domain.User.GlobalData PasaTurnosInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int32> Update(Spartane.Core.Domain.PasaTurnos.PasaTurnos entity, Spartane.Core.Domain.User.GlobalData PasaTurnosInformation, DataLayerFieldsBitacora DataReference);

        ApiResponse<IList<Spartane.Core.Domain.PasaTurnos.PasaTurnos>> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        ApiResponse<IList<Spartane.Core.Domain.PasaTurnos.PasaTurnos>> SelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.PasaTurnos.PasaTurnos>> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<Spartane.Core.Domain.PasaTurnos.PasaTurnosPagingModel> ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.PasaTurnos.PasaTurnos>> ListaSelAll(Boolean ConRelaciones, string Where);
		ApiResponse<int> GenerateID();
		ApiResponse<int> Update_Datos_Generales(Spartane.Core.Domain.PasaTurnos.PasaTurnos_Datos_Generales entity);
		ApiResponse<Spartane.Core.Domain.PasaTurnos.PasaTurnos_Datos_Generales> Get_Datos_Generales(string Key);


    }
}

