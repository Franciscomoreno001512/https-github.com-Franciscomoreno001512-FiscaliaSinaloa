using System;
using System.Data;
using Spartane.Core;
using Spartane.Core.Data;
using Spartane.Data.EF;
using Spartane.Core.Domain.Rol_de_Diligencia;
using System.Collections.Generic;
using System.Linq;
using Spartane.Core.Exceptions;
using Spartane.Core.Exceptions.Service;
using System.Linq.Dynamic;

namespace Spartane.Services.Rol_de_Diligencia
{
    /// <summary>
    /// Authentication Service
    /// </summary>
    public partial class Rol_de_DiligenciaService : IRol_de_DiligenciaService
    {
        #region Fields
        private readonly IDataProvider _dataProvider;
        private readonly IDbContext _dbContext;
        private readonly IRepository<Spartane.Core.Domain.Rol_de_Diligencia.Rol_de_Diligencia> _Rol_de_DiligenciaRepository;
        #endregion

        #region Ctor
        public Rol_de_DiligenciaService(IDataProvider dataProvider, IDbContext dbContext, IRepository<Spartane.Core.Domain.Rol_de_Diligencia.Rol_de_Diligencia> Rol_de_DiligenciaRepository)
        {
            this._dataProvider = dataProvider;
            this._dbContext = dbContext;
            this._Rol_de_DiligenciaRepository = Rol_de_DiligenciaRepository;
        }
        #endregion

        #region CRUD Operations
        public int SelCount()
        {
            return 0;
        }

        public IList<Spartane.Core.Domain.Rol_de_Diligencia.Rol_de_Diligencia> SelAll(bool ConRelaciones)
        {
            return this._Rol_de_DiligenciaRepository.Table.ToList();
        }

        public IList<Core.Domain.Rol_de_Diligencia.Rol_de_Diligencia> SelAllComplete(bool ConRelaciones)
        {
            return this._Rol_de_DiligenciaRepository.Table.ToList();
        }

        public int ListaSelAllCount(string Where)
        {
            return 0;
        }


        public IList<Spartane.Core.Domain.Rol_de_Diligencia.Rol_de_Diligencia> SelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Rol_de_DiligenciaRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Rol_de_Diligencia.Rol_de_Diligencia> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            return this._Rol_de_DiligenciaRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Rol_de_Diligencia.Rol_de_Diligencia> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Rol_de_DiligenciaRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Rol_de_Diligencia.Rol_de_DiligenciaPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            Rol_de_DiligenciaPagingModel result = null;
            return result;
        }

        public IList<Spartane.Core.Domain.Rol_de_Diligencia.Rol_de_Diligencia> ListaSelAll(bool ConRelaciones, string Where)
        {
            return this._Rol_de_DiligenciaRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Rol_de_Diligencia.Rol_de_Diligencia GetByKey(short Key, bool ConRelaciones)
        {
            Spartane.Core.Domain.Rol_de_Diligencia.Rol_de_Diligencia result=null;
            return result;
        }

        public bool Delete(short Key, Spartane.Core.Domain.User.GlobalData Rol_de_DiligenciaInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            var rta = true;
            return rta;
        }

        public short Insert(Spartane.Core.Domain.Rol_de_Diligencia.Rol_de_Diligencia entity, Spartane.Core.Domain.User.GlobalData Rol_de_DiligenciaInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            short rta = Convert.ToInt16("0");
            return rta;
        }

        public short Update(Spartane.Core.Domain.Rol_de_Diligencia.Rol_de_Diligencia entity, Spartane.Core.Domain.User.GlobalData Rol_de_DiligenciaInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            short rta = Convert.ToInt16("0");
            return rta;
        }
        #endregion
    }
}

