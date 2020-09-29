using ProductsAndSuppliers.Utilities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProductsAndSuppliers.Entities
{
    /// <summary>
    /// Represents an object of the <see cref="CovidCountryData"/> class containing COVID-19 tracking data like <see cref="Country"/>, <see cref="Cases"/>, and so on.
    /// </summary>
    /// <exception cref="ArgumentException"></exception>
    public class Corona
    {
        #region Fields
        protected string country;
        protected ulong updated;
        protected int cases;
        protected int todayCases;
        protected int deaths;
        protected int todayDeaths;
        protected int recovered;
        protected int active;
        protected int critical;
        protected double? casesPerOneMillion;
        protected double? deathsPerOneMillion;
        protected int tests;
        protected double? testsPerOneMillion;
        protected double? population;
        protected string continent;
        protected double? oneCasePerPeople;
        protected double? oneDeathPerPeople;
        protected double? oneTestPerPeople;
        protected double? activePerOneMillion;
        protected double? recoveredPerOneMillion;
        protected double? criticalPerOneMillion;
        #endregion

        #region Constructors
        /// <summary>
        ///  Initialises a new instance of an <see cref="CovidCountryData"/> object.
        /// </summary>
        /// <param name="country"></param>
        /// <param name="updated"></param>
        /// <param name="cases"></param>
        /// <param name="todayCases"></param>
        /// <param name="deaths"></param>
        /// <param name="todayDeaths"></param>
        /// <param name="recovered"></param>
        /// <param name="active"></param>
        /// <param name="critical"></param>
        /// <param name="casesPerOneMillion"></param>
        /// <param name="deathsPerOneMillion"></param>
        /// <param name="tests"></param>
        /// <param name="testsPerOneMillion"></param>
        /// <param name="population"></param>
        /// <param name="continent"></param>
        /// <param name="activePerOneMillion"></param>
        /// <param name="recoveredPerOneMillion"></param>
        /// <param name="criticalPerOneMillion"></param>
        /// <param name="oneCasePerPeople"></param>
        /// <param name="oneDeathPerPeople"></param>
        /// <param name="oneTestPerPeople"></param>
        /// <exception cref="ArgumentException"></exception>
        public Corona(string country, ulong updated, int cases, int todayCases, int deaths, int todayDeaths, int recovered, int active, int critical, double? casesPerOneMillion, double? deathsPerOneMillion, int tests, double? testsPerOneMillion, double? population, string continent, double? activePerOneMillion, double? recoveredPerOneMillion, double? criticalPerOneMillion, double? oneCasePerPeople, double? oneDeathPerPeople, double? oneTestPerPeople)
        {
            Country = country;
            Updated = updated;
            Cases = cases;
            TodayCases = todayCases;
            Deaths = deaths;
            TodayDeaths = todayDeaths;
            Recovered = recovered;
            Active = active;
            Critical = critical;
            CasesPerOneMillion = casesPerOneMillion;
            DeathsPerOneMillion = deathsPerOneMillion;
            Tests = tests;
            TestsPerOneMillion = testsPerOneMillion;
            Population = population;
            Continent = continent;
            ActivePerOneMillion = activePerOneMillion;
            RecoveredPerOneMillion = recoveredPerOneMillion;
            CriticalPerOneMillion = criticalPerOneMillion;
            OneCasePerPeople = oneCasePerPeople;
            OneDeathPerPeople = oneDeathPerPeople;
            OneTestPerPeople = oneTestPerPeople;
        }
        #endregion

        #region Properties
        /// <summary>
        /// The country of the <see cref="CovidCountryData"/>
        /// </summary>
        /// <exception cref="ArgumentException"></exception>
        public virtual string Country
        {
            get
            {
                return country;
            }
            set
            {
                (bool isValid, string errorMessage) = Validations.ValidateIsStringNull(value);
                if(isValid)
                {
                    if(country != value)
                    {
                        country = value;
                    }
                }
                else
                {
                    throw new ArgumentException(errorMessage, nameof(Country));
                }
            }
        }

        public virtual ulong Updated
        {
            get
            {
                return updated;
            }
            set
            {
                (bool isValid, string errorMessage) = Validations.ValidateIsUlongNegative(value);
                if(isValid)
                {
                    if(updated != value)
                    {
                        updated = value;
                    }
                }
                else
                {
                    throw new ArgumentException(errorMessage, nameof(Updated));
                }
            }
        }

        /// <summary>
        /// The amount of cases in the <see cref="Country"/>
        /// </summary>
        /// <exception cref="ArgumentException"></exception>
        public virtual int Cases
        {
            get
            {
                return cases;
            }
            set
            {
                (bool isValid, string errorMessage) = Validations.ValidateIsIntNegative(value);
                if(isValid)
                {
                    if(cases != value)
                    {
                        cases = value;
                    }
                }
                else
                {
                    throw new ArgumentException(errorMessage, nameof(Cases));
                }
            }
        }

        /// <summary>
        /// The amount of cases on the current date in the <see cref="Country"/>
        /// </summary>
        /// <exception cref="ArgumentException"></exception>
        public virtual int TodayCases
        {
            get
            {
                return todayCases;
            }
            set
            {
                (bool isValid, string errorMessage) = Validations.ValidateIsIntNegative(value);
                if(isValid)
                {
                    if(todayCases != value)
                    {
                        todayCases = value;
                    }
                }
                else
                {
                    throw new ArgumentException(errorMessage, nameof(TodayCases));
                }
            }
        }

        /// <summary>
        /// The amount of deaths in the <see cref="Country"/>
        /// </summary>
        /// <exception cref="ArgumentException"></exception>
        public virtual int Deaths
        {
            get
            {
                return deaths;
            }
            set
            {
                (bool isValid, string errorMessage) = Validations.ValidateIsIntNegative(value);
                if(isValid)
                {
                    if(deaths != value)
                    {
                        deaths = value;
                    }
                }
                else
                {
                    throw new ArgumentException(errorMessage, nameof(Deaths));
                }
            }
        }

        /// <summary>
        /// The amounts of deaths on the current date in the <see cref="Country"/>
        /// </summary>
        /// <exception cref="ArgumentException"></exception>
        public virtual int TodayDeaths
        {
            get
            {
                return todayDeaths;
            }
            set
            {
                (bool isValid, string errorMessage) = Validations.ValidateIsIntNegative(value);
                if(isValid)
                {
                    if(todayCases != value)
                    {
                        todayDeaths = value;
                    }
                }
                else
                {
                    throw new ArgumentException(errorMessage, nameof(TodayDeaths));
                }
            }
        }

        /// <summary>
        /// The amount of recovered in the <see cref="Country"/>
        /// </summary>
        /// <exception cref="ArgumentException"></exception>
        public virtual int Recovered
        {
            get
            {
                return recovered;
            }
            set
            {
                (bool isValid, string errorMessage) = Validations.ValidateIsIntNegative(value);
                if(isValid)
                {
                    if(recovered != value)
                    {
                        recovered = value;
                    }
                }
                else
                {
                    throw new ArgumentException(errorMessage, nameof(Recovered));
                }
            }
        }

        public virtual int Active
        {
            get
            {
                return active;
            }
            set
            {
                (bool isValid, string errorMessage) = Validations.ValidateIsIntNegative(value);
                if(isValid)
                {
                    if(active != value)
                    {
                        active = value;
                    }
                }
                else
                {
                    throw new ArgumentException(errorMessage, nameof(Active));
                }
            }
        }

        /// <summary>
        /// The amount of critial persons in the <see cref="Country"/>
        /// </summary>
        /// <exception cref="ArgumentException"></exception>
        public virtual int Critical
        {
            get
            {
                return critical;
            }
            set
            {
                (bool isValid, string errorMessage) = Validations.ValidateIsIntNegative(value);
                if(isValid)
                {
                    if(critical != value)
                    {
                        critical = value;
                    }
                }
                else
                {
                    throw new ArgumentException(errorMessage, nameof(Critical));
                }
            }
        }

        public virtual double? CasesPerOneMillion
        {
            get
            {
                return casesPerOneMillion;
            }
            set
            {
                (bool isValid, string errorMessage) = Validations.ValidateIsNullableDoubleNegative(value);
                if(isValid)
                {
                    if(casesPerOneMillion != value)
                    {
                        casesPerOneMillion = value;
                    }
                }
                else
                {
                    throw new ArgumentException(errorMessage, nameof(CasesPerOneMillion));
                }
            }
        }

        public virtual double? DeathsPerOneMillion
        {
            get
            {
                return deathsPerOneMillion;
            }
            set
            {
                (bool isValid, string errorMessage) = Validations.ValidateIsNullableDoubleNegative(value);
                if(isValid)
                {
                    if(deathsPerOneMillion != value)
                    {
                        deathsPerOneMillion = value;
                    }
                }
                else
                {
                    throw new ArgumentException(errorMessage, nameof(DeathsPerOneMillion));
                }
            }
        }

        public int Tests
        {
            get
            {
                return tests;
            }
            set
            {
                (bool isValid, string errorMessage) = Validations.ValidateIsIntNegative(value);
                if(isValid)
                {
                    if(tests != value)
                    {
                        tests = value;
                    }
                }
                else
                {
                    throw new ArgumentException(errorMessage, nameof(Tests));
                }
            }
        }

        public double? TestsPerOneMillion
        {
            get
            {
                return testsPerOneMillion;
            }
            set
            {
                (bool isValid, string errorMessage) = Validations.ValidateIsNullableDoubleNegative(value);
                if(isValid)
                {
                    if(testsPerOneMillion != value)
                    {
                        testsPerOneMillion = value;
                    }
                }
                else
                {
                    throw new ArgumentException(errorMessage, nameof(TestsPerOneMillion));
                }
            }
        }

        public double? Population
        {
            get
            {
                return population;
            }
            set
            {
                (bool isValid, string errorMessage) = Validations.ValidateIsNullableDoubleNegative(value);
                if(isValid)
                {
                    if(population != value)
                    {
                        population = value;
                    }
                }
                else
                {
                    throw new ArgumentException(errorMessage, nameof(Population));
                }
            }
        }

        public string Continent
        {
            get
            {
                return continent;
            }
            set
            {
                continent = value;
            }
        }

        public double? ActivePerOneMillion
        {
            get
            {
                return activePerOneMillion;
            }
            set
            {
                activePerOneMillion = value;
            }
        }

        public double? RecoveredPerOneMillion
        {
            get
            {
                return recoveredPerOneMillion;
            }
            set
            {
                recoveredPerOneMillion = value;
            }
        }

        public double? CriticalPerOneMillion
        {
            get
            {
                return criticalPerOneMillion;
            }
            set
            {
                criticalPerOneMillion = value;
            }
        }

        public double? OneCasePerPeople
        {
            get
            {
                return oneCasePerPeople;
            }
            set
            {
                oneCasePerPeople = value;
            }
        }

        public double? OneDeathPerPeople
        {
            get
            {
                return oneDeathPerPeople;
            }
            set
            {
                oneDeathPerPeople = value;
            }
        }

        public double? OneTestPerPeople
        {
            get
            {
                return oneTestPerPeople;
            }
            set
            {
                oneTestPerPeople = value;
            }
        }
        #endregion

        #region Methods
        public override string ToString()
        {
            return $"Country: {country}\n\n" +
                $"Tests: {tests}\n" +
                $"Active: {active}\n" +
                $"Critical: {critical}\n\n" +
                $"Total Cases: {cases}\n" +
                $"Total Deaths: {deaths}\n" +
                $"Recovered: {recovered}\n" +
                $"Cases Today: {todayCases}\n" +
                $"Deaths Today: {todayDeaths}\n\n" +
                $"Cases per one million: {casesPerOneMillion}\n" +
                $"Deaths per one million: {deathsPerOneMillion}\n" +
                $"Tests per one million: {testsPerOneMillion}\n\n" +
                $"Updated: {updated}";
        }
        #endregion
    }
}
