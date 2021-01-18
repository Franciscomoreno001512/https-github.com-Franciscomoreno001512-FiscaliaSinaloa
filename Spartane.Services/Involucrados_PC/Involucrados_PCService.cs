using System;
using System.Data;
using Spartane.Core;
using Spartane.Core.Data;
using Spartane.Data.EF;
using Spartane.Core.Domain.Involucrados_PC;
using System.Collections.Generic;
using System.Linq;
using Spartane.Core.Exceptions;
using Spartane.Core.Exceptions.Service;
using System.Linq.Dynamic;

namespace Spartane.Services.Involucrados_PC
{
    /// <summary>
    /// Authentication Service
    /// </summary>
    public partial class Involucrados_PCService : IInvolucrados_PCService
    {
        #region Fields
        private readonly IDataProvider _dataProvider;
        private readonly IDbContext _dbContext;
        private readonly IRepository<Spartane.Core.Domain.Involucrados_PC.Involucrados_PC> _Involucrados_PCRepository;
        #endregion

        #region Ctor
        public Involucrados_PCService(IDataProvider dataProvider, IDbContext dbContext, IRepository<Spartane.Core.Domain.Involucrados_PC.Involucrados_PC> Involucrados_PCRepository)
        {
            this._dataProvider = dataProvider;
            this._dbContext = dbContext;
            this._Involucrados_PCRepository = Involucrados_PCRepository;
        }
        #endregion

        #region CRUD Operations
        public int SelCount()
        {
            return 0;
        }

        public IList<Spartane.Core.Domain.Involucrados_PC.Involucrados_PC> SelAll(bool ConRelaciones)
        {
            return this._Involucrados_PCRepository.Table.ToList();
        }

        public IList<Core.Domain.Involucrados_PC.Involucrados_PC> SelAllComplete(bool ConRelaciones)
        {
            return this._Involucrados_PCRepository.Table.ToList();
        }

        public int ListaSelAllCount(string Where)
        {
            return 0;
        }


        public IList<Spartane.Core.Domain.Involucrados_PC.Involucrados_PC> SelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Involucrados_PCRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Involucrados_PC.Involucrados_PC> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            return this._Involucrados_PCRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Involucrados_PC.Involucrados_PC> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Involucrados_PCRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Involucrados_PC.Involucrados_PCPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            Involucrados_PCPagingModel result = null;
            return result;
        }

        public IList<Spartane.Core.Domain.Involucrados_PC.Involucrados_PC> ListaSelAll(bool ConRelaciones, string Where)
        {
            return this._Involucrados_PCRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Involucrados_PC.Involucrados_PC GetByKey(int Key, bool ConRelaciones)
        {
            Spartane.Core.Domain.Involucrados_PC.Involucrados_PC result=null;
            return result;
        }

        public bool Delete(int Key, Spartane.Core.Domain.User.GlobalData Involucrados_PCInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            var rta = true;
            return rta;
        }

        public int Insert(Spartane.Core.Domain.Involucrados_PC.Involucrados_PC entity, Spartane.Core.Domain.User.GlobalData Involucrados_PCInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }

        public int Update(Spartane.Core.Domain.Involucrados_PC.Involucrados_PC entity, Spartane.Core.Domain.User.GlobalData Involucrados_PCInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }
        #endregion
    }
}

