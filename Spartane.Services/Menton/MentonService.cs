using System;
using System.Data;
using Spartane.Core;
using Spartane.Core.Data;
using Spartane.Data.EF;
using Spartane.Core.Domain.Menton;
using System.Collections.Generic;
using System.Linq;
using Spartane.Core.Exceptions;
using Spartane.Core.Exceptions.Service;
using System.Linq.Dynamic;

namespace Spartane.Services.Menton
{
    /// <summary>
    /// Authentication Service
    /// </summary>
    public partial class MentonService : IMentonService
    {
        #region Fields
        private readonly IDataProvider _dataProvider;
        private readonly IDbContext _dbContext;
        private readonly IRepository<Spartane.Core.Domain.Menton.Menton> _MentonRepository;
        #endregion

        #region Ctor
        public MentonService(IDataProvider dataProvider, IDbContext dbContext, IRepository<Spartane.Core.Domain.Menton.Menton> MentonRepository)
        {
            this._dataProvider = dataProvider;
            this._dbContext = dbContext;
            this._MentonRepository = MentonRepository;
        }
        #endregion

        #region CRUD Operations
        public int SelCount()
        {
            return 0;
        }

        public IList<Spartane.Core.Domain.Menton.Menton> SelAll(bool ConRelaciones)
        {
            return this._MentonRepository.Table.ToList();
        }

        public IList<Core.Domain.Menton.Menton> SelAllComplete(bool ConRelaciones)
        {
            return this._MentonRepository.Table.ToList();
        }

        public int ListaSelAllCount(string Where)
        {
            return 0;
        }


        public IList<Spartane.Core.Domain.Menton.Menton> SelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._MentonRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Menton.Menton> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            return this._MentonRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Menton.Menton> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._MentonRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Menton.MentonPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            MentonPagingModel result = null;
            return result;
        }

        public IList<Spartane.Core.Domain.Menton.Menton> ListaSelAll(bool ConRelaciones, string Where)
        {
            return this._MentonRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Menton.Menton GetByKey(int Key, bool ConRelaciones)
        {
            Spartane.Core.Domain.Menton.Menton result=null;
            return result;
        }

        public bool Delete(int Key, Spartane.Core.Domain.User.GlobalData MentonInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            var rta = true;
            return rta;
        }

        public int Insert(Spartane.Core.Domain.Menton.Menton entity, Spartane.Core.Domain.User.GlobalData MentonInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }

        public int Update(Spartane.Core.Domain.Menton.Menton entity, Spartane.Core.Domain.User.GlobalData MentonInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }
        #endregion
    }
}

