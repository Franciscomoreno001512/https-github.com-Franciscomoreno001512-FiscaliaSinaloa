using System;
using Spartane.Core.Domain.Grupo_al_que_Pertenece;
using System.Collections.Generic;
using Spartane.Core.Domain.Data;

namespace Spartane.Services.Grupo_al_que_Pertenece
{
    /// <summary>
    /// Authentificated Service
    /// </summary>
    public partial interface IGrupo_al_que_PerteneceService
    {
        Int32 SelCount();
        IList<Spartane.Core.Domain.Grupo_al_que_Pertenece.Grupo_al_que_Pertenece> SelAll(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Grupo_al_que_Pertenece.Grupo_al_que_Pertenece> SelAllComplete(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Grupo_al_que_Pertenece.Grupo_al_que_Pertenece> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        Spartane.Core.Domain.Grupo_al_que_Pertenece.Grupo_al_que_Pertenece GetByKey(int Key, Boolean ConRelaciones);
        bool Delete(int Key, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Insert(Spartane.Core.Domain.Grupo_al_que_Pertenece.Grupo_al_que_Pertenece entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Update(Spartane.Core.Domain.Grupo_al_que_Pertenece.Grupo_al_que_Pertenece entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        IList<Spartane.Core.Domain.Grupo_al_que_Pertenece.Grupo_al_que_Pertenece> SelAll(Boolean ConRelaciones, string Where, string Order);
        IList<Spartane.Core.Domain.Grupo_al_que_Pertenece.Grupo_al_que_Pertenece> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        Spartane.Core.Domain.Grupo_al_que_Pertenece.Grupo_al_que_PertenecePagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        int ListaSelAllCount(string Where);
        IList<Spartane.Core.Domain.Grupo_al_que_Pertenece.Grupo_al_que_Pertenece> ListaSelAll(Boolean ConRelaciones, string Where);
    }
}
