using System;
using Spartane.Core.Domain.Partida_que_Cumplimenta;
using System.Collections.Generic;
using Spartane.Core.Domain.Data;

namespace Spartane.Services.Partida_que_Cumplimenta
{
    /// <summary>
    /// Authentificated Service
    /// </summary>
    public partial interface IPartida_que_CumplimentaService
    {
        Int32 SelCount();
        IList<Spartane.Core.Domain.Partida_que_Cumplimenta.Partida_que_Cumplimenta> SelAll(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Partida_que_Cumplimenta.Partida_que_Cumplimenta> SelAllComplete(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Partida_que_Cumplimenta.Partida_que_Cumplimenta> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        Spartane.Core.Domain.Partida_que_Cumplimenta.Partida_que_Cumplimenta GetByKey(int Key, Boolean ConRelaciones);
        bool Delete(int Key, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Insert(Spartane.Core.Domain.Partida_que_Cumplimenta.Partida_que_Cumplimenta entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Update(Spartane.Core.Domain.Partida_que_Cumplimenta.Partida_que_Cumplimenta entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        IList<Spartane.Core.Domain.Partida_que_Cumplimenta.Partida_que_Cumplimenta> SelAll(Boolean ConRelaciones, string Where, string Order);
        IList<Spartane.Core.Domain.Partida_que_Cumplimenta.Partida_que_Cumplimenta> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        Spartane.Core.Domain.Partida_que_Cumplimenta.Partida_que_CumplimentaPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        int ListaSelAllCount(string Where);
        IList<Spartane.Core.Domain.Partida_que_Cumplimenta.Partida_que_Cumplimenta> ListaSelAll(Boolean ConRelaciones, string Where);
    }
}
