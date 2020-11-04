using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Data;
using Spartane.Web.Areas.WebApiConsumer.ResponseHelpers;

namespace Spartane.Web.Areas.WebApiConsumer.Grosor_de_Labios
{
    public interface IGrosor_de_LabiosApiConsumer
    {
        void SetAuthHeader(string token);
        Int32 SelCount();
        ApiResponse<IList<Spartane.Core.Domain.Grosor_de_Labios.Grosor_de_Labios>> SelAll(Boolean ConRelaciones);
        ApiResponse<IList<Spartane.Core.Domain.Grosor_de_Labios.Grosor_de_Labios>> SelAllComplete(Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.Grosor_de_Labios.Grosor_de_Labios> GetByKey(int Key, Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.Grosor_de_Labios.Grosor_de_LabiosPagingModel> GetByKeyComplete(int Key);
        ApiResponse<bool> Delete(int Key, Spartane.Core.Domain.User.GlobalData Grosor_de_LabiosInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int32> Insert(Spartane.Core.Domain.Grosor_de_Labios.Grosor_de_Labios entity, Spartane.Core.Domain.User.GlobalData Grosor_de_LabiosInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int32> Update(Spartane.Core.Domain.Grosor_de_Labios.Grosor_de_Labios entity, Spartane.Core.Domain.User.GlobalData Grosor_de_LabiosInformation, DataLayerFieldsBitacora DataReference);

        ApiResponse<IList<Spartane.Core.Domain.Grosor_de_Labios.Grosor_de_Labios>> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        ApiResponse<IList<Spartane.Core.Domain.Grosor_de_Labios.Grosor_de_Labios>> SelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.Grosor_de_Labios.Grosor_de_Labios>> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<Spartane.Core.Domain.Grosor_de_Labios.Grosor_de_LabiosPagingModel> ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.Grosor_de_Labios.Grosor_de_Labios>> ListaSelAll(Boolean ConRelaciones, string Where);
		ApiResponse<int> GenerateID();
		ApiResponse<int> Update_Datos_Generales(Spartane.Core.Domain.Grosor_de_Labios.Grosor_de_Labios_Datos_Generales entity);
		ApiResponse<Spartane.Core.Domain.Grosor_de_Labios.Grosor_de_Labios_Datos_Generales> Get_Datos_Generales(string Key);


    }
}

