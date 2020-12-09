using System;
using System.Data;
using Spartane.Core;
using Spartane.Core.Data;
using Spartane.Data.EF;
using Spartane.Core.Domain.Generador_de_NUAT;
using System.Collections.Generic;
using System.Linq;
using Spartane.Core.Exceptions;
using Spartane.Core.Exceptions.Service;
using System.Linq.Dynamic;

namespace Spartane.Services.Generador_de_NUAT
{
    /// <summary>
    /// Authentication Service
    /// </summary>
    public partial class Generador_de_NUATService : IGenerador_de_NUATService
    {
        #region Fields
        private readonly IDataProvider _dataProvider;
        private readonly IDbContext _dbContext;
        private readonly IRepository<Spartane.Core.Domain.Generador_de_NUAT.Generador_de_NUAT> _Generador_de_NUATRepository;
        #endregion

        #region Ctor
        public Generador_de_NUATService(IDataProvider dataProvider, IDbContext dbContext, IRepository<Spartane.Core.Domain.Generador_de_NUAT.Generador_de_NUAT> Generador_de_NUATRepository)
        {
            this._dataProvider = dataProvider;
            this._dbContext = dbContext;
            this._Generador_de_NUATRepository = Generador_de_NUATRepository;
        }
        #endregion

        #region CRUD Operations
        public int SelCount()
        {
            return 0;
        }

        public IList<Spartane.Core.Domain.Generador_de_NUAT.Generador_de_NUAT> SelAll(bool ConRelaciones)
        {
            return this._Generador_de_NUATRepository.Table.ToList();
        }

        public IList<Core.Domain.Generador_de_NUAT.Generador_de_NUAT> SelAllComplete(bool ConRelaciones)
        {
            return this._Generador_de_NUATRepository.Table.ToList();
        }

        public int ListaSelAllCount(string Where)
        {
            return 0;
        }


        public IList<Spartane.Core.Domain.Generador_de_NUAT.Generador_de_NUAT> SelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Generador_de_NUATRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Generador_de_NUAT.Generador_de_NUAT> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            return this._Generador_de_NUATRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Generador_de_NUAT.Generador_de_NUAT> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Generador_de_NUATRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Generador_de_NUAT.Generador_de_NUATPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            Generador_de_NUATPagingModel result = null;
            return result;
        }

        public IList<Spartane.Core.Domain.Generador_de_NUAT.Generador_de_NUAT> ListaSelAll(bool ConRelaciones, string Where)
        {
            return this._Generador_de_NUATRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Generador_de_NUAT.Generador_de_NUAT GetByKey(int Key, bool ConRelaciones)
        {
            Spartane.Core.Domain.Generador_de_NUAT.Generador_de_NUAT result=null;
            return result;
        }

        public bool Delete(int Key, Spartane.Core.Domain.User.GlobalData Generador_de_NUATInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            var rta = true;
            return rta;
        }

        public int Insert(Spartane.Core.Domain.Generador_de_NUAT.Generador_de_NUAT entity, Spartane.Core.Domain.User.GlobalData Generador_de_NUATInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }

        public int Update(Spartane.Core.Domain.Generador_de_NUAT.Generador_de_NUAT entity, Spartane.Core.Domain.User.GlobalData Generador_de_NUATInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }
        #endregion
    }
}

