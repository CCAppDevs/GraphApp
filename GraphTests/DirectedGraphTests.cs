using GraphLib;
namespace GraphTests
{
    [TestClass]
    public class DirectedGraphTests
    {
        [TestMethod]
        public void AddingANodeToTheGraph_ShouldReturnAVertex()
        {
            // arrange
            DirectedGraph graph = new DirectedGraph();

            // act
            var result = graph.AddVertex("Toast");

            // assert
            Assert.IsInstanceOfType<Vertex>(result);
            Assert.AreEqual(result.Label, "Toast");
        }

        [TestMethod]
        [DataRow("Toast", "Butter", "Lawnmower")]
        public void AddingMoreThanOneNodeToTheGraph_ShouldRetainEachOfThem(string one, string two, string three)
        {
            // arrange
            DirectedGraph graph = new DirectedGraph();

            // act
            graph.AddVertex(one);
            graph.AddVertex(two);
            graph.AddVertex(three);

            var result = graph.NumVertices;

            var resultOne = graph.Vertices[0];
            var resultTwo = graph.Vertices[1];
            var resultThree = graph.Vertices[2];

            // assert
            Assert.AreEqual(3, result);
            Assert.AreEqual(one, resultOne.Label);
            Assert.AreEqual(two, resultTwo.Label);
            Assert.AreEqual(three, resultThree.Label);
        }
    }
}