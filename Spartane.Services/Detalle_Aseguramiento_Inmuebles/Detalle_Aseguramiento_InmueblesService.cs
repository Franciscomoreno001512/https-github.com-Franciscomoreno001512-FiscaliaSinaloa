using System;
using System.Data;
using Spartane.Core;
using Spartane.Core.Data;
using Spartane.Data.EF;
using Spartane.Core.Domain.Detalle_Aseguramiento_Inmuebles;
using System.Collections.Generic;
using System.Linq;
using Spartane.Core.Exceptions;
using Spartane.Core.Exceptions.Service;
using System.Linq.Dynamic;

namespace Spartane.Services.Detalle_Aseguramiento_Inmuebles
{
    /// <summary>
    /// Authentication Service
    /// </summary>
    public partial class Detalle_Aseguramiento_InmueblesService : IDetalle_Aseguramiento_InmueblesService
    {
        #region Fields
        private readonly IDataProvider _dataProvider;
        private readonly IDbContext _dbContext;
        private readonly IRepository<Spartane.Core.Domain.Detalle_Aseguramiento_Inmuebles.Detalle_Aseguramiento_Inmuebles> _Detalle_Aseguramiento_InmueblesRepository;
        #endregion

        #region Ctor
        public Detalle_Aseguramiento_InmueblesService(IDataProvider dataProvider, IDbContext dbContext, IRepository<Spartane.Core.Domain.Detalle_Aseguramiento_Inmuebles.Detalle_Aseguramiento_Inmuebles> Detalle_Aseguramiento_InmueblesRepository)
        {
            this._dataProvider = dataProvider;
            this._dbContext = dbContext;
            this._Detalle_Aseguramiento_InmueblesRepository = Detalle_Aseguramiento_InmueblesRepository;
        }
        #endregion

        #region CRUD Operations
        public int SelCount()
        {
            return 0;
        }

        public IList<Spartane.Core.Domain.Detalle_Aseguramiento_Inmuebles.Detalle_Aseguramiento_Inmuebles> SelAll(bool ConRelaciones)
        {
            return this._Detalle_Aseguramiento_InmueblesRepository.Table.ToList();
        }

        public IList<Core.Domain.Detalle_Aseguramiento_Inmuebles.Detalle_Aseguramiento_Inmuebles> SelAllComplete(bool ConRelaciones)
        {
            return this._Detalle_Aseguramiento_InmueblesRepository.Table.ToList();
        }

        public int ListaSelAllCount(string Where)
        {
            return 0;
        }


        public IList<Spartane.Core.Domain.Detalle_Aseguramiento_Inmuebles.Detalle_Aseguramiento_Inmuebles> SelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Detalle_Aseguramiento_InmueblesRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Detalle_Aseguramiento_Inmuebles.Detalle_Aseguramiento_Inmuebles> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            return this._Detalle_Aseguramiento_InmueblesRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Detalle_Aseguramiento_Inmuebles.Detalle_Aseguramiento_Inmuebles> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Detalle_Aseguramiento_InmueblesRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Detalle_Aseguramiento_Inmuebles.Detalle_Aseguramiento_InmueblesPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            Detalle_Aseguramiento_InmueblesPagingModel result = null;
            return result;
        }

        public IList<Spartane.Core.Domain.Detalle_Aseguramiento_Inmuebles.Detalle_Aseguramiento_Inmuebles> ListaSelAll(bool ConRelaciones, string Where)
        {
            return this._Detalle_Aseguramiento_InmueblesRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Detalle_Aseguramiento_Inmuebles.Detalle_Aseguramiento_Inmuebles GetByKey(int Key, bool ConRelaciones)
        {
            Spartane.Core.Domain.Detalle_Aseguramiento_Inmuebles.Detalle_Aseguramiento_Inmuebles result=null;
            return result;
        }

        public bool Delete(int Key, Spartane.Core.Domain.User.GlobalData Detalle_Aseguramiento_InmueblesInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            var rta = true;
            return rta;
        }

        public int Insert(Spartane.Core.Domain.Detalle_Aseguramiento_Inmuebles.Detalle_Aseguramiento_Inmuebles entity, Spartane.Core.Domain.User.GlobalData Detalle_Aseguramiento_InmueblesInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }

        public int Update(Spartane.Core.Domain.Detalle_Aseguramiento_Inmuebles.Detalle_Aseguramiento_Inmuebles entity, Spartane.Core.Domain.User.GlobalData Detalle_Aseguramiento_InmueblesInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }
        #endregion
    }
}

