using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Data;
using Spartane.Web.Areas.WebApiConsumer.ResponseHelpers;

namespace Spartane.Web.Areas.WebApiConsumer.Reporte_Principal
{
    public interface IReporte_PrincipalApiConsumer
    {
        void SetAuthHeader(string token);
        Int32 SelCount();
        ApiResponse<IList<Spartane.Core.Domain.Reporte_Principal.Reporte_Principal>> SelAll(Boolean ConRelaciones);
        ApiResponse<IList<Spartane.Core.Domain.Reporte_Principal.Reporte_Principal>> SelAllComplete(Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.Reporte_Principal.Reporte_Principal> GetByKey(int Key, Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.Reporte_Principal.Reporte_PrincipalPagingModel> GetByKeyComplete(int Key);
        ApiResponse<bool> Delete(int Key, Spartane.Core.Domain.User.GlobalData Reporte_PrincipalInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int32> Insert(Spartane.Core.Domain.Reporte_Principal.Reporte_Principal entity, Spartane.Core.Domain.User.GlobalData Reporte_PrincipalInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int32> Update(Spartane.Core.Domain.Reporte_Principal.Reporte_Principal entity, Spartane.Core.Domain.User.GlobalData Reporte_PrincipalInformation, DataLayerFieldsBitacora DataReference);

        ApiResponse<IList<Spartane.Core.Domain.Reporte_Principal.Reporte_Principal>> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        ApiResponse<IList<Spartane.Core.Domain.Reporte_Principal.Reporte_Principal>> SelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.Reporte_Principal.Reporte_Principal>> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<Spartane.Core.Domain.Reporte_Principal.Reporte_PrincipalPagingModel> ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.Reporte_Principal.Reporte_Principal>> ListaSelAll(Boolean ConRelaciones, string Where);
		ApiResponse<int> GenerateID();
		ApiResponse<int> Update_Datos_Generales(Spartane.Core.Domain.Reporte_Principal.Reporte_Principal_Datos_Generales entity);
		ApiResponse<Spartane.Core.Domain.Reporte_Principal.Reporte_Principal_Datos_Generales> Get_Datos_Generales(string Key);


    }
}

