using System;
using System.Data;
using Spartane.Core;
using Spartane.Core.Data;
using Spartane.Data.EF;
using Spartane.Core.Domain.Detalle_de_Relaciones;
using System.Collections.Generic;
using System.Linq;
using Spartane.Core.Exceptions;
using Spartane.Core.Exceptions.Service;
using System.Linq.Dynamic;

namespace Spartane.Services.Detalle_de_Relaciones
{
    /// <summary>
    /// Authentication Service
    /// </summary>
    public partial class Detalle_de_RelacionesService : IDetalle_de_RelacionesService
    {
        #region Fields
        private readonly IDataProvider _dataProvider;
        private readonly IDbContext _dbContext;
        private readonly IRepository<Spartane.Core.Domain.Detalle_de_Relaciones.Detalle_de_Relaciones> _Detalle_de_RelacionesRepository;
        #endregion

        #region Ctor
        public Detalle_de_RelacionesService(IDataProvider dataProvider, IDbContext dbContext, IRepository<Spartane.Core.Domain.Detalle_de_Relaciones.Detalle_de_Relaciones> Detalle_de_RelacionesRepository)
        {
            this._dataProvider = dataProvider;
            this._dbContext = dbContext;
            this._Detalle_de_RelacionesRepository = Detalle_de_RelacionesRepository;
        }
        #endregion

        #region CRUD Operations
        public int SelCount()
        {
            return 0;
        }

        public IList<Spartane.Core.Domain.Detalle_de_Relaciones.Detalle_de_Relaciones> SelAll(bool ConRelaciones)
        {
            return this._Detalle_de_RelacionesRepository.Table.ToList();
        }

        public IList<Core.Domain.Detalle_de_Relaciones.Detalle_de_Relaciones> SelAllComplete(bool ConRelaciones)
        {
            return this._Detalle_de_RelacionesRepository.Table.ToList();
        }

        public int ListaSelAllCount(string Where)
        {
            return 0;
        }


        public IList<Spartane.Core.Domain.Detalle_de_Relaciones.Detalle_de_Relaciones> SelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Detalle_de_RelacionesRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Detalle_de_Relaciones.Detalle_de_Relaciones> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            return this._Detalle_de_RelacionesRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Detalle_de_Relaciones.Detalle_de_Relaciones> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Detalle_de_RelacionesRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Detalle_de_Relaciones.Detalle_de_RelacionesPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            Detalle_de_RelacionesPagingModel result = null;
            return result;
        }

        public IList<Spartane.Core.Domain.Detalle_de_Relaciones.Detalle_de_Relaciones> ListaSelAll(bool ConRelaciones, string Where)
        {
            return this._Detalle_de_RelacionesRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Detalle_de_Relaciones.Detalle_de_Relaciones GetByKey(int Key, bool ConRelaciones)
        {
            Spartane.Core.Domain.Detalle_de_Relaciones.Detalle_de_Relaciones result=null;
            return result;
        }

        public bool Delete(int Key, Spartane.Core.Domain.User.GlobalData Detalle_de_RelacionesInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            var rta = true;
            return rta;
        }

        public int Insert(Spartane.Core.Domain.Detalle_de_Relaciones.Detalle_de_Relaciones entity, Spartane.Core.Domain.User.GlobalData Detalle_de_RelacionesInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }

        public int Update(Spartane.Core.Domain.Detalle_de_Relaciones.Detalle_de_Relaciones entity, Spartane.Core.Domain.User.GlobalData Detalle_de_RelacionesInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }
        #endregion
    }
}

