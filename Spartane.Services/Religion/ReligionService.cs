using System;
using System.Data;
using Spartane.Core;
using Spartane.Core.Data;
using Spartane.Data.EF;
using Spartane.Core.Domain.Religion;
using System.Collections.Generic;
using System.Linq;
using Spartane.Core.Exceptions;
using Spartane.Core.Exceptions.Service;
using System.Linq.Dynamic;

namespace Spartane.Services.Religion
{
    /// <summary>
    /// Authentication Service
    /// </summary>
    public partial class ReligionService : IReligionService
    {
        #region Fields
        private readonly IDataProvider _dataProvider;
        private readonly IDbContext _dbContext;
        private readonly IRepository<Spartane.Core.Domain.Religion.Religion> _ReligionRepository;
        #endregion

        #region Ctor
        public ReligionService(IDataProvider dataProvider, IDbContext dbContext, IRepository<Spartane.Core.Domain.Religion.Religion> ReligionRepository)
        {
            this._dataProvider = dataProvider;
            this._dbContext = dbContext;
            this._ReligionRepository = ReligionRepository;
        }
        #endregion

        #region CRUD Operations
        public int SelCount()
        {
            return 0;
        }

        public IList<Spartane.Core.Domain.Religion.Religion> SelAll(bool ConRelaciones)
        {
            return this._ReligionRepository.Table.ToList();
        }

        public IList<Core.Domain.Religion.Religion> SelAllComplete(bool ConRelaciones)
        {
            return this._ReligionRepository.Table.ToList();
        }

        public int ListaSelAllCount(string Where)
        {
            return 0;
        }


        public IList<Spartane.Core.Domain.Religion.Religion> SelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._ReligionRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Religion.Religion> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            return this._ReligionRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Religion.Religion> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._ReligionRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Religion.ReligionPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            ReligionPagingModel result = null;
            return result;
        }

        public IList<Spartane.Core.Domain.Religion.Religion> ListaSelAll(bool ConRelaciones, string Where)
        {
            return this._ReligionRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Religion.Religion GetByKey(short Key, bool ConRelaciones)
        {
            Spartane.Core.Domain.Religion.Religion result=null;
            return result;
        }

        public bool Delete(short Key, Spartane.Core.Domain.User.GlobalData ReligionInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            var rta = true;
            return rta;
        }

        public short Insert(Spartane.Core.Domain.Religion.Religion entity, Spartane.Core.Domain.User.GlobalData ReligionInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            short rta = Convert.ToInt16("0");
            return rta;
        }

        public short Update(Spartane.Core.Domain.Religion.Religion entity, Spartane.Core.Domain.User.GlobalData ReligionInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            short rta = Convert.ToInt16("0");
            return rta;
        }
        #endregion
    }
}

