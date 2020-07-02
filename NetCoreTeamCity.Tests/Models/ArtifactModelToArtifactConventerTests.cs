using FluentAssertions;
using NetCoreTeamCity.Models;
using NUnit.Framework;

namespace NetCoreTeamCity.Tests.Models
{
    [TestFixture]
    public class ArtifactModelToArtifactConventerTests
    {
        [Test]
        public void ArtifactModel_ConvertTo_Artifact()
        {
            var model = new ArtifactModel()
            {
                Name = "name",
                Size = "size",
                Content = new ArtifactModelContent()
                {
                    Href = "content href"
                },
                Href = "href"
            };

            var artifact = model.Convert();

            artifact.Name.Should().Be(model.Name);
            artifact.Size.Should().Be(model.Size);
            artifact.Content.Value.Should().Be(model.Content.Href);
            artifact.Metadata.Value.Should().Be(model.Href);
        }
    }
}