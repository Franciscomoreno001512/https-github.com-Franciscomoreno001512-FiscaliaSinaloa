using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Data;
using Spartane.Web.Areas.WebApiConsumer.ResponseHelpers;

namespace Spartane.Web.Areas.WebApiConsumer.Detalle_de_Datos_del_Imputado_MPI
{
    public interface IDetalle_de_Datos_del_Imputado_MPIApiConsumer
    {
        void SetAuthHeader(string token);
        Int32 SelCount();
        ApiResponse<IList<Spartane.Core.Domain.Detalle_de_Datos_del_Imputado_MPI.Detalle_de_Datos_del_Imputado_MPI>> SelAll(Boolean ConRelaciones);
        ApiResponse<IList<Spartane.Core.Domain.Detalle_de_Datos_del_Imputado_MPI.Detalle_de_Datos_del_Imputado_MPI>> SelAllComplete(Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.Detalle_de_Datos_del_Imputado_MPI.Detalle_de_Datos_del_Imputado_MPI> GetByKey(int Key, Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.Detalle_de_Datos_del_Imputado_MPI.Detalle_de_Datos_del_Imputado_MPIPagingModel> GetByKeyComplete(int Key);
        ApiResponse<bool> Delete(int Key, Spartane.Core.Domain.User.GlobalData Detalle_de_Datos_del_Imputado_MPIInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int32> Insert(Spartane.Core.Domain.Detalle_de_Datos_del_Imputado_MPI.Detalle_de_Datos_del_Imputado_MPI entity, Spartane.Core.Domain.User.GlobalData Detalle_de_Datos_del_Imputado_MPIInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int32> Update(Spartane.Core.Domain.Detalle_de_Datos_del_Imputado_MPI.Detalle_de_Datos_del_Imputado_MPI entity, Spartane.Core.Domain.User.GlobalData Detalle_de_Datos_del_Imputado_MPIInformation, DataLayerFieldsBitacora DataReference);

        ApiResponse<IList<Spartane.Core.Domain.Detalle_de_Datos_del_Imputado_MPI.Detalle_de_Datos_del_Imputado_MPI>> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        ApiResponse<IList<Spartane.Core.Domain.Detalle_de_Datos_del_Imputado_MPI.Detalle_de_Datos_del_Imputado_MPI>> SelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.Detalle_de_Datos_del_Imputado_MPI.Detalle_de_Datos_del_Imputado_MPI>> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<Spartane.Core.Domain.Detalle_de_Datos_del_Imputado_MPI.Detalle_de_Datos_del_Imputado_MPIPagingModel> ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.Detalle_de_Datos_del_Imputado_MPI.Detalle_de_Datos_del_Imputado_MPI>> ListaSelAll(Boolean ConRelaciones, string Where);
		ApiResponse<int> GenerateID();
		ApiResponse<int> Update_Datos_Generales(Spartane.Core.Domain.Detalle_de_Datos_del_Imputado_MPI.Detalle_de_Datos_del_Imputado_MPI_Datos_Generales entity);
		ApiResponse<Spartane.Core.Domain.Detalle_de_Datos_del_Imputado_MPI.Detalle_de_Datos_del_Imputado_MPI_Datos_Generales> Get_Datos_Generales(string Key);

		ApiResponse<int> Update__Datos_de_Media_Filiacion(Spartane.Core.Domain.Detalle_de_Datos_del_Imputado_MPI.Detalle_de_Datos_del_Imputado_MPI__Datos_de_Media_Filiacion entity);
		ApiResponse<Spartane.Core.Domain.Detalle_de_Datos_del_Imputado_MPI.Detalle_de_Datos_del_Imputado_MPI__Datos_de_Media_Filiacion> Get__Datos_de_Media_Filiacion(string Key);

		ApiResponse<int> Update_Control_de_Tiempos(Spartane.Core.Domain.Detalle_de_Datos_del_Imputado_MPI.Detalle_de_Datos_del_Imputado_MPI_Control_de_Tiempos entity);
		ApiResponse<Spartane.Core.Domain.Detalle_de_Datos_del_Imputado_MPI.Detalle_de_Datos_del_Imputado_MPI_Control_de_Tiempos> Get_Control_de_Tiempos(string Key);

		ApiResponse<int> Update_Datos_de_los_Hechos(Spartane.Core.Domain.Detalle_de_Datos_del_Imputado_MPI.Detalle_de_Datos_del_Imputado_MPI_Datos_de_los_Hechos entity);
		ApiResponse<Spartane.Core.Domain.Detalle_de_Datos_del_Imputado_MPI.Detalle_de_Datos_del_Imputado_MPI_Datos_de_los_Hechos> Get_Datos_de_los_Hechos(string Key);

		ApiResponse<int> Update_Datos_del_Abogado(Spartane.Core.Domain.Detalle_de_Datos_del_Imputado_MPI.Detalle_de_Datos_del_Imputado_MPI_Datos_del_Abogado entity);
		ApiResponse<Spartane.Core.Domain.Detalle_de_Datos_del_Imputado_MPI.Detalle_de_Datos_del_Imputado_MPI_Datos_del_Abogado> Get_Datos_del_Abogado(string Key);

		ApiResponse<int> Update_Datos_del_Tutor(Spartane.Core.Domain.Detalle_de_Datos_del_Imputado_MPI.Detalle_de_Datos_del_Imputado_MPI_Datos_del_Tutor entity);
		ApiResponse<Spartane.Core.Domain.Detalle_de_Datos_del_Imputado_MPI.Detalle_de_Datos_del_Imputado_MPI_Datos_del_Tutor> Get_Datos_del_Tutor(string Key);

		ApiResponse<int> Update_Sentencias(Spartane.Core.Domain.Detalle_de_Datos_del_Imputado_MPI.Detalle_de_Datos_del_Imputado_MPI_Sentencias entity);
		ApiResponse<Spartane.Core.Domain.Detalle_de_Datos_del_Imputado_MPI.Detalle_de_Datos_del_Imputado_MPI_Sentencias> Get_Sentencias(string Key);


    }
}

