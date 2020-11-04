using System;
using System.Data;
using Spartane.Core;
using Spartane.Core.Data;
using Spartane.Data.EF;
using Spartane.Core.Domain.Grupo_Vulnerable;
using System.Collections.Generic;
using System.Linq;
using Spartane.Core.Exceptions;
using Spartane.Core.Exceptions.Service;
using System.Linq.Dynamic;

namespace Spartane.Services.Grupo_Vulnerable
{
    /// <summary>
    /// Authentication Service
    /// </summary>
    public partial class Grupo_VulnerableService : IGrupo_VulnerableService
    {
        #region Fields
        private readonly IDataProvider _dataProvider;
        private readonly IDbContext _dbContext;
        private readonly IRepository<Spartane.Core.Domain.Grupo_Vulnerable.Grupo_Vulnerable> _Grupo_VulnerableRepository;
        #endregion

        #region Ctor
        public Grupo_VulnerableService(IDataProvider dataProvider, IDbContext dbContext, IRepository<Spartane.Core.Domain.Grupo_Vulnerable.Grupo_Vulnerable> Grupo_VulnerableRepository)
        {
            this._dataProvider = dataProvider;
            this._dbContext = dbContext;
            this._Grupo_VulnerableRepository = Grupo_VulnerableRepository;
        }
        #endregion

        #region CRUD Operations
        public int SelCount()
        {
            return 0;
        }

        public IList<Spartane.Core.Domain.Grupo_Vulnerable.Grupo_Vulnerable> SelAll(bool ConRelaciones)
        {
            return this._Grupo_VulnerableRepository.Table.ToList();
        }

        public IList<Core.Domain.Grupo_Vulnerable.Grupo_Vulnerable> SelAllComplete(bool ConRelaciones)
        {
            return this._Grupo_VulnerableRepository.Table.ToList();
        }

        public int ListaSelAllCount(string Where)
        {
            return 0;
        }


        public IList<Spartane.Core.Domain.Grupo_Vulnerable.Grupo_Vulnerable> SelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Grupo_VulnerableRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Grupo_Vulnerable.Grupo_Vulnerable> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            return this._Grupo_VulnerableRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Grupo_Vulnerable.Grupo_Vulnerable> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Grupo_VulnerableRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Grupo_Vulnerable.Grupo_VulnerablePagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            Grupo_VulnerablePagingModel result = null;
            return result;
        }

        public IList<Spartane.Core.Domain.Grupo_Vulnerable.Grupo_Vulnerable> ListaSelAll(bool ConRelaciones, string Where)
        {
            return this._Grupo_VulnerableRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Grupo_Vulnerable.Grupo_Vulnerable GetByKey(short Key, bool ConRelaciones)
        {
            Spartane.Core.Domain.Grupo_Vulnerable.Grupo_Vulnerable result=null;
            return result;
        }

        public bool Delete(short Key, Spartane.Core.Domain.User.GlobalData Grupo_VulnerableInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            var rta = true;
            return rta;
        }

        public short Insert(Spartane.Core.Domain.Grupo_Vulnerable.Grupo_Vulnerable entity, Spartane.Core.Domain.User.GlobalData Grupo_VulnerableInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            short rta = Convert.ToInt16("0");
            return rta;
        }

        public short Update(Spartane.Core.Domain.Grupo_Vulnerable.Grupo_Vulnerable entity, Spartane.Core.Domain.User.GlobalData Grupo_VulnerableInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            short rta = Convert.ToInt16("0");
            return rta;
        }
        #endregion
    }
}

