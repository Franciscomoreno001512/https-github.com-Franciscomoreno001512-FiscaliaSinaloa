using System;
using System.Data;
using Spartane.Core;
using Spartane.Core.Data;
using Spartane.Data.EF;
using Spartane.Core.Domain.PasaTurnos;
using System.Collections.Generic;
using System.Linq;
using Spartane.Core.Exceptions;
using Spartane.Core.Exceptions.Service;
using System.Linq.Dynamic;

namespace Spartane.Services.PasaTurnos
{
    /// <summary>
    /// Authentication Service
    /// </summary>
    public partial class PasaTurnosService : IPasaTurnosService
    {
        #region Fields
        private readonly IDataProvider _dataProvider;
        private readonly IDbContext _dbContext;
        private readonly IRepository<Spartane.Core.Domain.PasaTurnos.PasaTurnos> _PasaTurnosRepository;
        #endregion

        #region Ctor
        public PasaTurnosService(IDataProvider dataProvider, IDbContext dbContext, IRepository<Spartane.Core.Domain.PasaTurnos.PasaTurnos> PasaTurnosRepository)
        {
            this._dataProvider = dataProvider;
            this._dbContext = dbContext;
            this._PasaTurnosRepository = PasaTurnosRepository;
        }
        #endregion

        #region CRUD Operations
        public int SelCount()
        {
            return 0;
        }

        public IList<Spartane.Core.Domain.PasaTurnos.PasaTurnos> SelAll(bool ConRelaciones)
        {
            return this._PasaTurnosRepository.Table.ToList();
        }

        public IList<Core.Domain.PasaTurnos.PasaTurnos> SelAllComplete(bool ConRelaciones)
        {
            return this._PasaTurnosRepository.Table.ToList();
        }

        public int ListaSelAllCount(string Where)
        {
            return 0;
        }


        public IList<Spartane.Core.Domain.PasaTurnos.PasaTurnos> SelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._PasaTurnosRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.PasaTurnos.PasaTurnos> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            return this._PasaTurnosRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.PasaTurnos.PasaTurnos> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._PasaTurnosRepository.Table.ToList();
        }

        public Spartane.Core.Domain.PasaTurnos.PasaTurnosPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            PasaTurnosPagingModel result = null;
            return result;
        }

        public IList<Spartane.Core.Domain.PasaTurnos.PasaTurnos> ListaSelAll(bool ConRelaciones, string Where)
        {
            return this._PasaTurnosRepository.Table.ToList();
        }

        public Spartane.Core.Domain.PasaTurnos.PasaTurnos GetByKey(int Key, bool ConRelaciones)
        {
            Spartane.Core.Domain.PasaTurnos.PasaTurnos result=null;
            return result;
        }

        public bool Delete(int Key, Spartane.Core.Domain.User.GlobalData PasaTurnosInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            var rta = true;
            return rta;
        }

        public int Insert(Spartane.Core.Domain.PasaTurnos.PasaTurnos entity, Spartane.Core.Domain.User.GlobalData PasaTurnosInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }

        public int Update(Spartane.Core.Domain.PasaTurnos.PasaTurnos entity, Spartane.Core.Domain.User.GlobalData PasaTurnosInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }
        #endregion
    }
}

