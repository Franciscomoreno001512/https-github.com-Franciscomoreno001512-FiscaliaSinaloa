using System;
using System.Data;
using Spartane.Core;
using Spartane.Core.Data;
using Spartane.Data.EF;
using Spartane.Core.Domain.Certifica_Defuncion;
using System.Collections.Generic;
using System.Linq;
using Spartane.Core.Exceptions;
using Spartane.Core.Exceptions.Service;
using System.Linq.Dynamic;

namespace Spartane.Services.Certifica_Defuncion
{
    /// <summary>
    /// Authentication Service
    /// </summary>
    public partial class Certifica_DefuncionService : ICertifica_DefuncionService
    {
        #region Fields
        private readonly IDataProvider _dataProvider;
        private readonly IDbContext _dbContext;
        private readonly IRepository<Spartane.Core.Domain.Certifica_Defuncion.Certifica_Defuncion> _Certifica_DefuncionRepository;
        #endregion

        #region Ctor
        public Certifica_DefuncionService(IDataProvider dataProvider, IDbContext dbContext, IRepository<Spartane.Core.Domain.Certifica_Defuncion.Certifica_Defuncion> Certifica_DefuncionRepository)
        {
            this._dataProvider = dataProvider;
            this._dbContext = dbContext;
            this._Certifica_DefuncionRepository = Certifica_DefuncionRepository;
        }
        #endregion

        #region CRUD Operations
        public int SelCount()
        {
            return 0;
        }

        public IList<Spartane.Core.Domain.Certifica_Defuncion.Certifica_Defuncion> SelAll(bool ConRelaciones)
        {
            return this._Certifica_DefuncionRepository.Table.ToList();
        }

        public IList<Core.Domain.Certifica_Defuncion.Certifica_Defuncion> SelAllComplete(bool ConRelaciones)
        {
            return this._Certifica_DefuncionRepository.Table.ToList();
        }

        public int ListaSelAllCount(string Where)
        {
            return 0;
        }


        public IList<Spartane.Core.Domain.Certifica_Defuncion.Certifica_Defuncion> SelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Certifica_DefuncionRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Certifica_Defuncion.Certifica_Defuncion> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            return this._Certifica_DefuncionRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Certifica_Defuncion.Certifica_Defuncion> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Certifica_DefuncionRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Certifica_Defuncion.Certifica_DefuncionPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            Certifica_DefuncionPagingModel result = null;
            return result;
        }

        public IList<Spartane.Core.Domain.Certifica_Defuncion.Certifica_Defuncion> ListaSelAll(bool ConRelaciones, string Where)
        {
            return this._Certifica_DefuncionRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Certifica_Defuncion.Certifica_Defuncion GetByKey(short Key, bool ConRelaciones)
        {
            Spartane.Core.Domain.Certifica_Defuncion.Certifica_Defuncion result=null;
            return result;
        }

        public bool Delete(short Key, Spartane.Core.Domain.User.GlobalData Certifica_DefuncionInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            var rta = true;
            return rta;
        }

        public short Insert(Spartane.Core.Domain.Certifica_Defuncion.Certifica_Defuncion entity, Spartane.Core.Domain.User.GlobalData Certifica_DefuncionInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            short rta = Convert.ToInt16("0");
            return rta;
        }

        public short Update(Spartane.Core.Domain.Certifica_Defuncion.Certifica_Defuncion entity, Spartane.Core.Domain.User.GlobalData Certifica_DefuncionInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            short rta = Convert.ToInt16("0");
            return rta;
        }
        #endregion
    }
}

