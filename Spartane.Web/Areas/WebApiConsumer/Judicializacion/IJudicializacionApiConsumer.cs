using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Data;
using Spartane.Web.Areas.WebApiConsumer.ResponseHelpers;

namespace Spartane.Web.Areas.WebApiConsumer.Judicializacion
{
    public interface IJudicializacionApiConsumer
    {
        void SetAuthHeader(string token);
        Int32 SelCount();
        ApiResponse<IList<Spartane.Core.Domain.Judicializacion.Judicializacion>> SelAll(Boolean ConRelaciones);
        ApiResponse<IList<Spartane.Core.Domain.Judicializacion.Judicializacion>> SelAllComplete(Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.Judicializacion.Judicializacion> GetByKey(int Key, Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.Judicializacion.JudicializacionPagingModel> GetByKeyComplete(int Key);
        ApiResponse<bool> Delete(int Key, Spartane.Core.Domain.User.GlobalData JudicializacionInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int32> Insert(Spartane.Core.Domain.Judicializacion.Judicializacion entity, Spartane.Core.Domain.User.GlobalData JudicializacionInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int32> Update(Spartane.Core.Domain.Judicializacion.Judicializacion entity, Spartane.Core.Domain.User.GlobalData JudicializacionInformation, DataLayerFieldsBitacora DataReference);

        ApiResponse<IList<Spartane.Core.Domain.Judicializacion.Judicializacion>> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        ApiResponse<IList<Spartane.Core.Domain.Judicializacion.Judicializacion>> SelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.Judicializacion.Judicializacion>> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<Spartane.Core.Domain.Judicializacion.JudicializacionPagingModel> ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.Judicializacion.Judicializacion>> ListaSelAll(Boolean ConRelaciones, string Where);
		ApiResponse<int> GenerateID();
		ApiResponse<int> Update_Datos_Generales(Spartane.Core.Domain.Judicializacion.Judicializacion_Datos_Generales entity);
		ApiResponse<Spartane.Core.Domain.Judicializacion.Judicializacion_Datos_Generales> Get_Datos_Generales(string Key);

		ApiResponse<int> Update_Actos_de_Investigacion(Spartane.Core.Domain.Judicializacion.Judicializacion_Actos_de_Investigacion entity);
		ApiResponse<Spartane.Core.Domain.Judicializacion.Judicializacion_Actos_de_Investigacion> Get_Actos_de_Investigacion(string Key);

		ApiResponse<int> Update_Genericos(Spartane.Core.Domain.Judicializacion.Judicializacion_Genericos entity);
		ApiResponse<Spartane.Core.Domain.Judicializacion.Judicializacion_Genericos> Get_Genericos(string Key);

		ApiResponse<int> Update_Fase_Inicial(Spartane.Core.Domain.Judicializacion.Judicializacion_Fase_Inicial entity);
		ApiResponse<Spartane.Core.Domain.Judicializacion.Judicializacion_Fase_Inicial> Get_Fase_Inicial(string Key);

		ApiResponse<int> Update_Fase_Intermedia(Spartane.Core.Domain.Judicializacion.Judicializacion_Fase_Intermedia entity);
		ApiResponse<Spartane.Core.Domain.Judicializacion.Judicializacion_Fase_Intermedia> Get_Fase_Intermedia(string Key);

		ApiResponse<int> Update_Fase_Juicio_Oral(Spartane.Core.Domain.Judicializacion.Judicializacion_Fase_Juicio_Oral entity);
		ApiResponse<Spartane.Core.Domain.Judicializacion.Judicializacion_Fase_Juicio_Oral> Get_Fase_Juicio_Oral(string Key);

		ApiResponse<int> Update_Salidas_Alternas(Spartane.Core.Domain.Judicializacion.Judicializacion_Salidas_Alternas entity);
		ApiResponse<Spartane.Core.Domain.Judicializacion.Judicializacion_Salidas_Alternas> Get_Salidas_Alternas(string Key);

		ApiResponse<int> Update_Sobreseimientos(Spartane.Core.Domain.Judicializacion.Judicializacion_Sobreseimientos entity);
		ApiResponse<Spartane.Core.Domain.Judicializacion.Judicializacion_Sobreseimientos> Get_Sobreseimientos(string Key);

		ApiResponse<int> Update_Movimientos(Spartane.Core.Domain.Judicializacion.Judicializacion_Movimientos entity);
		ApiResponse<Spartane.Core.Domain.Judicializacion.Judicializacion_Movimientos> Get_Movimientos(string Key);


    }
}

