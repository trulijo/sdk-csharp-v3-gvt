﻿using Trulioo.Client.V3.Models.Business;
using Trulioo.Client.V3.Models.Fields;
using Trulioo.Client.V3.Models.Verification;
using Xunit;
using Business = Trulioo.Client.V3.Models.Fields.Business;

namespace Trulioo.Client.V3.Tests
{
    public class BusinessFacts
    {
        [Theory(Skip = "Calls API")]
        [MemberData(nameof(BusinessSearchTestData))]
        public async void BusinessSearchTest(BusinessSearchRequest request, BusinessSearchResponse expectedResponse)
        {
            //Arrange
            using var client = await BaseFact.GetTruliooKYBClientAsync();
            var response = await client.TruliooBusiness.BusinessSearchAsync(request);

            Assert.Equal(expectedResponse.Record.RecordStatus, response.Record.RecordStatus);
            Assert.Equal(expectedResponse.CountryCode, response.CountryCode);

            Assert.Equal(expectedResponse.Record.DatasourceResults.Count(), response.Record.DatasourceResults.Count());
            List<string> expectedDatasourcesNames = expectedResponse.Record.DatasourceResults.Select(x => x.DatasourceName).ToList();
            List<string> actualDatasourceNames = response.Record.DatasourceResults.Select(x => x.DatasourceName).ToList();
            Assert.True(expectedDatasourcesNames.All(actualDatasourceNames.Contains));

            List<string> expectedBusinessNameResults = expectedResponse.Record.DatasourceResults.SelectMany(datasource => datasource.Results.Select(result => result.BusinessName)).ToList();
            List<string> actualBusinessNameResults = response.Record.DatasourceResults.SelectMany(datasource => datasource.Results.Select(result => result.BusinessName)).ToList();
            Assert.Equal(expectedBusinessNameResults.Count(), actualBusinessNameResults.Count());
            Assert.True(expectedBusinessNameResults.All(actualBusinessNameResults.Contains));

            List<string> expectedBusinessNumberResults = expectedResponse.Record.DatasourceResults.SelectMany(datasource => datasource.Results.Select(result => result.BusinessRegistrationNumber)).ToList();
            List<string> actualBusinessNumberResults = response.Record.DatasourceResults.SelectMany(datasource => datasource.Results.Select(result => result.BusinessRegistrationNumber)).ToList();
            Assert.Equal(expectedBusinessNumberResults.Count(), actualBusinessNumberResults.Count());
            Assert.True(expectedBusinessNumberResults.All(actualBusinessNumberResults.Contains));
        }

        [Theory(Skip = "Calls API")]
        [MemberData(nameof(BusinessVerifyTestData))]
        public async void BusinessVerifyTest(VerifyRequest request)
        {
            using var client = await BaseFact.GetTruliooKYBClientAsync();
            var response = await client.TruliooBusiness.BusinessVerifyAsync(request);

            Assert.NotNull(response);
        }

        [Theory(Skip = "Calls API")]
        [InlineData("CA", null)]
        [InlineData("CA", "BC")]
        [InlineData(null, null)]
        [InlineData(" ", "")]
        [InlineData("", "BC")]
        [InlineData(null, "BC")]
        public async Task GetBusinessRegistrationNumbers(string countryCode, string jurisdiction)
        {
            using var client = await BaseFact.GetTruliooKYBClientAsync();

            if (string.IsNullOrWhiteSpace(countryCode) && !string.IsNullOrWhiteSpace(jurisdiction))
            {
                await Assert.ThrowsAsync<ArgumentException>(async () => await client.TruliooBusiness.GetBusinessRegistrationNumbersAsync(countryCode, jurisdiction));
            }
            else
            {
                var response = await client.TruliooBusiness.GetBusinessRegistrationNumbersAsync(countryCode, jurisdiction);
                Assert.NotNull(response);
            }
            
        }

        [Theory(Skip = "Calls API")]
        [InlineData("CA")]
        [InlineData(null)]
        [InlineData(" ")]
        public async Task GetCountryJOI(string countryCode)
        {
            using var client = await BaseFact.GetTruliooKYBClientAsync();
            var response = await client.TruliooBusiness.GetCountryJOIAsync(countryCode);
            Assert.NotNull(response);
        }


        #region Member Data

        public static IEnumerable<object[]> BusinessSearchTestData()
        {
            yield return new object[]
            {
                new BusinessSearchRequest {
                    PackageId = BaseFact.PackageId,
                    CountryCode = "CA",
                    Timeout = 100,
                    Business = new BusinessSearchModel
                    {
                        BusinessName = "businessname",
                        JurisdictionOfIncorporation = "BC",
                        Website = "website",
                        Location = new Location()
                    }
                },
                new BusinessSearchResponse
                {
                    TransactionID = "",
                    CountryCode = "",
                    Record = new BusinessRecord
                    {
                        RecordStatus = "",
                        DatasourceResults = new List<BusinessSearchResult>{ 
                            new BusinessSearchResult {
                                DatasourceName = "",
                                Results = new List<BusinessResult>
                                {
                                    new BusinessResult
                                    {
                                        BusinessName = "",
                                        BusinessRegistrationNumber = "",
                                        JurisdictionOfIncorporation = ""
                                    }
                                }
                            }
                        }
                    }
                }
            };
        }

        public static IEnumerable<object[]> BusinessVerifyTestData()
        {
            yield return new object[]
            {
                new VerifyRequest
                {
                    VerboseMode = true,
                    CountryCode = "CA",
                    DataFields = new DataFields
                    {
                        Business = new Business
                        {
                            BusinessName = "BusinessName",
                            TradestyleName = "TradestyleName",
                            TaxIDNumber = "TaxIDNumber",
                            BusinessRegistrationNumber = "BusinessRegistrationNumber",
                            DayOfIncorporation = 1,
                            MonthOfIncorporation = 2,
                            YearOfIncorporation = 2003,
                            JurisdictionOfIncorporation = "JurisdictionOfIncorporation",
                            ShareholderListDocument = true,
                            FinancialInformationDocument = true,
                            EnhancedProfile = true,
                            DunsNumber = "DunsNumber",
                            Entities = true,
                            PeopleOfSignificantControl = new List<PersonOfSignificantControl>
                            {
                                new PersonOfSignificantControl
                                {
                                    FirstGivenName = "FirstGivenName",
                                    MiddleName = "MiddleName",
                                    FirstSurName = "FirstSurName",
                                    SecondSurname = "SecondSurname",
                                    FullName = "FullName",
                                    BusinessName = "BusinessName",
                                    YearOfBirth = "YearOfBirth",
                                    MonthOfBirth = "MonthOfBirth",
                                    DayOfBirth = "DayOfBirth",
                                }
                            },
                            Filings = true,
                            ArticleOfAssociation = true,
                            RegistrationDetails = true,
                            AnnualReport = true,
                        }
                    }
                },
            };
        }


        #endregion
    }
}
