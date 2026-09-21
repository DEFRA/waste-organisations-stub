namespace WasteOrganisationsStub.Test;

public sealed class EmbeddedStubDataTests
{
    [Fact]
    public void GetAllScenariosStubsIncludesKnownEmbeddedScenario()
    {
        var scenarios = EmbeddedStubData.GetAllScenariosStubs();

        Assert.Contains("_organisations_94bfc917-b9b6-45d7-847b-e5f500bfe198.json", scenarios);
    }
}
