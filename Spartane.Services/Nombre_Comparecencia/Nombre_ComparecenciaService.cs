using System;
using System.Data;
using Spartane.Core;
using Spartane.Core.Data;
using Spartane.Data.EF;
using Spartane.Core.Domain.Nombre_Comparecencia;
using System.Collections.Generic;
using System.Linq;
using Spartane.Core.Exceptions;
using Spartane.Core.Exceptions.Service;
using System.Linq.Dynamic;

namespace Spartane.Services.Nombre_Comparecencia
{
    /// <summary>
    /// Authentication Service
    /// </summary>
    public partial class Nombre_ComparecenciaService : INombre_ComparecenciaService
    {
        #region Fields
        private readonly IDataProvider _dataProvider;
        private readonly IDbContext _dbContext;
        private readonly IRepository<Spartane.Core.Domain.Nombre_Comparecencia.Nombre_Comparecencia> _Nombre_ComparecenciaRepository;
        #endregion

        #region Ctor
        public Nombre_ComparecenciaService(IDataProvider dataProvider, IDbContext dbContext, IRepository<Spartane.Core.Domain.Nombre_Comparecencia.Nombre_Comparecencia> Nombre_ComparecenciaRepository)
        {
            this._dataProvider = dataProvider;
            this._dbContext = dbContext;
            this._Nombre_ComparecenciaRepository = Nombre_ComparecenciaRepository;
        }
        #endregion

        #region CRUD Operations
        public int SelCount()
        {
            return 0;
        }

        public IList<Spartane.Core.Domain.Nombre_Comparecencia.Nombre_Comparecencia> SelAll(bool ConRelaciones)
        {
            return this._Nombre_ComparecenciaRepository.Table.ToList();
        }

        public IList<Core.Domain.Nombre_Comparecencia.Nombre_Comparecencia> SelAllComplete(bool ConRelaciones)
        {
            return this._Nombre_ComparecenciaRepository.Table.ToList();
        }

        public int ListaSelAllCount(string Where)
        {
            return 0;
        }


        public IList<Spartane.Core.Domain.Nombre_Comparecencia.Nombre_Comparecencia> SelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Nombre_ComparecenciaRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Nombre_Comparecencia.Nombre_Comparecencia> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            return this._Nombre_ComparecenciaRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Nombre_Comparecencia.Nombre_Comparecencia> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Nombre_ComparecenciaRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Nombre_Comparecencia.Nombre_ComparecenciaPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            Nombre_ComparecenciaPagingModel result = null;
            return result;
        }

        public IList<Spartane.Core.Domain.Nombre_Comparecencia.Nombre_Comparecencia> ListaSelAll(bool ConRelaciones, string Where)
        {
            return this._Nombre_ComparecenciaRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Nombre_Comparecencia.Nombre_Comparecencia GetByKey(int Key, bool ConRelaciones)
        {
            Spartane.Core.Domain.Nombre_Comparecencia.Nombre_Comparecencia result=null;
            return result;
        }

        public bool Delete(int Key, Spartane.Core.Domain.User.GlobalData Nombre_ComparecenciaInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            var rta = true;
            return rta;
        }

        public int Insert(Spartane.Core.Domain.Nombre_Comparecencia.Nombre_Comparecencia entity, Spartane.Core.Domain.User.GlobalData Nombre_ComparecenciaInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }

        public int Update(Spartane.Core.Domain.Nombre_Comparecencia.Nombre_Comparecencia entity, Spartane.Core.Domain.User.GlobalData Nombre_ComparecenciaInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }
        #endregion
    }
}

