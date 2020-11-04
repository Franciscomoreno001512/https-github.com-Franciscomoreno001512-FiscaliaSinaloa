using System;
using System.Data;
using Spartane.Core;
using Spartane.Core.Data;
using Spartane.Data.EF;
using Spartane.Core.Domain.Juez_de_Control;
using System.Collections.Generic;
using System.Linq;
using Spartane.Core.Exceptions;
using Spartane.Core.Exceptions.Service;
using System.Linq.Dynamic;

namespace Spartane.Services.Juez_de_Control
{
    /// <summary>
    /// Authentication Service
    /// </summary>
    public partial class Juez_de_ControlService : IJuez_de_ControlService
    {
        #region Fields
        private readonly IDataProvider _dataProvider;
        private readonly IDbContext _dbContext;
        private readonly IRepository<Spartane.Core.Domain.Juez_de_Control.Juez_de_Control> _Juez_de_ControlRepository;
        #endregion

        #region Ctor
        public Juez_de_ControlService(IDataProvider dataProvider, IDbContext dbContext, IRepository<Spartane.Core.Domain.Juez_de_Control.Juez_de_Control> Juez_de_ControlRepository)
        {
            this._dataProvider = dataProvider;
            this._dbContext = dbContext;
            this._Juez_de_ControlRepository = Juez_de_ControlRepository;
        }
        #endregion

        #region CRUD Operations
        public int SelCount()
        {
            return 0;
        }

        public IList<Spartane.Core.Domain.Juez_de_Control.Juez_de_Control> SelAll(bool ConRelaciones)
        {
            return this._Juez_de_ControlRepository.Table.ToList();
        }

        public IList<Core.Domain.Juez_de_Control.Juez_de_Control> SelAllComplete(bool ConRelaciones)
        {
            return this._Juez_de_ControlRepository.Table.ToList();
        }

        public int ListaSelAllCount(string Where)
        {
            return 0;
        }


        public IList<Spartane.Core.Domain.Juez_de_Control.Juez_de_Control> SelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Juez_de_ControlRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Juez_de_Control.Juez_de_Control> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            return this._Juez_de_ControlRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Juez_de_Control.Juez_de_Control> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Juez_de_ControlRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Juez_de_Control.Juez_de_ControlPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            Juez_de_ControlPagingModel result = null;
            return result;
        }

        public IList<Spartane.Core.Domain.Juez_de_Control.Juez_de_Control> ListaSelAll(bool ConRelaciones, string Where)
        {
            return this._Juez_de_ControlRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Juez_de_Control.Juez_de_Control GetByKey(int Key, bool ConRelaciones)
        {
            Spartane.Core.Domain.Juez_de_Control.Juez_de_Control result=null;
            return result;
        }

        public bool Delete(int Key, Spartane.Core.Domain.User.GlobalData Juez_de_ControlInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            var rta = true;
            return rta;
        }

        public int Insert(Spartane.Core.Domain.Juez_de_Control.Juez_de_Control entity, Spartane.Core.Domain.User.GlobalData Juez_de_ControlInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }

        public int Update(Spartane.Core.Domain.Juez_de_Control.Juez_de_Control entity, Spartane.Core.Domain.User.GlobalData Juez_de_ControlInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }
        #endregion
    }
}

