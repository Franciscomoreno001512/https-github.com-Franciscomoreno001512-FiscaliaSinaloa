using System;
using Spartane.Core.Domain.Terreno_de_Inmuebles;
using System.Collections.Generic;
using Spartane.Core.Domain.Data;

namespace Spartane.Services.Terreno_de_Inmuebles
{
    /// <summary>
    /// Authentificated Service
    /// </summary>
    public partial interface ITerreno_de_InmueblesService
    {
        Int32 SelCount();
        IList<Spartane.Core.Domain.Terreno_de_Inmuebles.Terreno_de_Inmuebles> SelAll(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Terreno_de_Inmuebles.Terreno_de_Inmuebles> SelAllComplete(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Terreno_de_Inmuebles.Terreno_de_Inmuebles> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        Spartane.Core.Domain.Terreno_de_Inmuebles.Terreno_de_Inmuebles GetByKey(short Key, Boolean ConRelaciones);
        bool Delete(short Key, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int16 Insert(Spartane.Core.Domain.Terreno_de_Inmuebles.Terreno_de_Inmuebles entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int16 Update(Spartane.Core.Domain.Terreno_de_Inmuebles.Terreno_de_Inmuebles entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        IList<Spartane.Core.Domain.Terreno_de_Inmuebles.Terreno_de_Inmuebles> SelAll(Boolean ConRelaciones, string Where, string Order);
        IList<Spartane.Core.Domain.Terreno_de_Inmuebles.Terreno_de_Inmuebles> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        Spartane.Core.Domain.Terreno_de_Inmuebles.Terreno_de_InmueblesPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        int ListaSelAllCount(string Where);
        IList<Spartane.Core.Domain.Terreno_de_Inmuebles.Terreno_de_Inmuebles> ListaSelAll(Boolean ConRelaciones, string Where);
    }
}
