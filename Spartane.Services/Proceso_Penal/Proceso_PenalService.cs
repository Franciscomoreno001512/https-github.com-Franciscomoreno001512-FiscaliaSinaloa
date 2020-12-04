using System;
using System.Data;
using Spartane.Core;
using Spartane.Core.Data;
using Spartane.Data.EF;
using Spartane.Core.Domain.Proceso_Penal;
using System.Collections.Generic;
using System.Linq;
using Spartane.Core.Exceptions;
using Spartane.Core.Exceptions.Service;
using System.Linq.Dynamic;

namespace Spartane.Services.Proceso_Penal
{
    /// <summary>
    /// Authentication Service
    /// </summary>
    public partial class Proceso_PenalService : IProceso_PenalService
    {
        #region Fields
        private readonly IDataProvider _dataProvider;
        private readonly IDbContext _dbContext;
        private readonly IRepository<Spartane.Core.Domain.Proceso_Penal.Proceso_Penal> _Proceso_PenalRepository;
        #endregion

        #region Ctor
        public Proceso_PenalService(IDataProvider dataProvider, IDbContext dbContext, IRepository<Spartane.Core.Domain.Proceso_Penal.Proceso_Penal> Proceso_PenalRepository)
        {
            this._dataProvider = dataProvider;
            this._dbContext = dbContext;
            this._Proceso_PenalRepository = Proceso_PenalRepository;
        }
        #endregion

        #region CRUD Operations
        public int SelCount()
        {
            return 0;
        }

        public IList<Spartane.Core.Domain.Proceso_Penal.Proceso_Penal> SelAll(bool ConRelaciones)
        {
            return this._Proceso_PenalRepository.Table.ToList();
        }

        public IList<Core.Domain.Proceso_Penal.Proceso_Penal> SelAllComplete(bool ConRelaciones)
        {
            return this._Proceso_PenalRepository.Table.ToList();
        }

        public int ListaSelAllCount(string Where)
        {
            return 0;
        }


        public IList<Spartane.Core.Domain.Proceso_Penal.Proceso_Penal> SelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Proceso_PenalRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Proceso_Penal.Proceso_Penal> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            return this._Proceso_PenalRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Proceso_Penal.Proceso_Penal> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Proceso_PenalRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Proceso_Penal.Proceso_PenalPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            Proceso_PenalPagingModel result = null;
            return result;
        }

        public IList<Spartane.Core.Domain.Proceso_Penal.Proceso_Penal> ListaSelAll(bool ConRelaciones, string Where)
        {
            return this._Proceso_PenalRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Proceso_Penal.Proceso_Penal GetByKey(int Key, bool ConRelaciones)
        {
            Spartane.Core.Domain.Proceso_Penal.Proceso_Penal result=null;
            return result;
        }

        public bool Delete(int Key, Spartane.Core.Domain.User.GlobalData Proceso_PenalInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            var rta = true;
            return rta;
        }

        public int Insert(Spartane.Core.Domain.Proceso_Penal.Proceso_Penal entity, Spartane.Core.Domain.User.GlobalData Proceso_PenalInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }

        public int Update(Spartane.Core.Domain.Proceso_Penal.Proceso_Penal entity, Spartane.Core.Domain.User.GlobalData Proceso_PenalInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }
        #endregion
    }
}

