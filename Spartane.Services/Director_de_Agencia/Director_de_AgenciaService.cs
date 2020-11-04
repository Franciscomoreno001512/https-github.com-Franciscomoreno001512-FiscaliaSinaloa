using System;
using System.Data;
using Spartane.Core;
using Spartane.Core.Data;
using Spartane.Data.EF;
using Spartane.Core.Domain.Director_de_Agencia;
using System.Collections.Generic;
using System.Linq;
using Spartane.Core.Exceptions;
using Spartane.Core.Exceptions.Service;
using System.Linq.Dynamic;

namespace Spartane.Services.Director_de_Agencia
{
    /// <summary>
    /// Authentication Service
    /// </summary>
    public partial class Director_de_AgenciaService : IDirector_de_AgenciaService
    {
        #region Fields
        private readonly IDataProvider _dataProvider;
        private readonly IDbContext _dbContext;
        private readonly IRepository<Spartane.Core.Domain.Director_de_Agencia.Director_de_Agencia> _Director_de_AgenciaRepository;
        #endregion

        #region Ctor
        public Director_de_AgenciaService(IDataProvider dataProvider, IDbContext dbContext, IRepository<Spartane.Core.Domain.Director_de_Agencia.Director_de_Agencia> Director_de_AgenciaRepository)
        {
            this._dataProvider = dataProvider;
            this._dbContext = dbContext;
            this._Director_de_AgenciaRepository = Director_de_AgenciaRepository;
        }
        #endregion

        #region CRUD Operations
        public int SelCount()
        {
            return 0;
        }

        public IList<Spartane.Core.Domain.Director_de_Agencia.Director_de_Agencia> SelAll(bool ConRelaciones)
        {
            return this._Director_de_AgenciaRepository.Table.ToList();
        }

        public IList<Core.Domain.Director_de_Agencia.Director_de_Agencia> SelAllComplete(bool ConRelaciones)
        {
            return this._Director_de_AgenciaRepository.Table.ToList();
        }

        public int ListaSelAllCount(string Where)
        {
            return 0;
        }


        public IList<Spartane.Core.Domain.Director_de_Agencia.Director_de_Agencia> SelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Director_de_AgenciaRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Director_de_Agencia.Director_de_Agencia> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            return this._Director_de_AgenciaRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Director_de_Agencia.Director_de_Agencia> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Director_de_AgenciaRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Director_de_Agencia.Director_de_AgenciaPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            Director_de_AgenciaPagingModel result = null;
            return result;
        }

        public IList<Spartane.Core.Domain.Director_de_Agencia.Director_de_Agencia> ListaSelAll(bool ConRelaciones, string Where)
        {
            return this._Director_de_AgenciaRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Director_de_Agencia.Director_de_Agencia GetByKey(int Key, bool ConRelaciones)
        {
            Spartane.Core.Domain.Director_de_Agencia.Director_de_Agencia result=null;
            return result;
        }

        public bool Delete(int Key, Spartane.Core.Domain.User.GlobalData Director_de_AgenciaInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            var rta = true;
            return rta;
        }

        public int Insert(Spartane.Core.Domain.Director_de_Agencia.Director_de_Agencia entity, Spartane.Core.Domain.User.GlobalData Director_de_AgenciaInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }

        public int Update(Spartane.Core.Domain.Director_de_Agencia.Director_de_Agencia entity, Spartane.Core.Domain.User.GlobalData Director_de_AgenciaInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }
        #endregion
    }
}

