# ---------//---------#
# Import Area

import networkx as nx
import matplotlib.pyplot as plt
import random

# ---------//---------#
# Code Area
# ---------//---------#

MAX_INT = 999


def min_dist(dist_array):
    min_value = MAX_INT
    current_min_node = None
    for dist in dist_array:
        if dist_array[dist] < min_value:
            min_value = dist_array[dist]
            current_min_node = dist
    return current_min_node


def shortest_path(graph, source):
    visited_nodes = []
    dist = {}
    prev = {}
    q = []
    for vertex in graph.nodes:
        dist[vertex] = MAX_INT
        if vertex == source:
            prev[vertex] = source
        else:
            prev[vertex] = None
        q.append(vertex)
    dist[source] = 0

    while len(q) != 0:
        u = min_dist(dist)
        q.remove(u)
        for neighbor in graph.neighbors(u):
            if neighbor in visited_nodes:
                continue
            alt = dist[u] + G.get_edge_data(u, neighbor)['weight']
            if alt < dist[neighbor]:
                dist[neighbor] = alt
                prev[neighbor] = u
        del dist[u]
        visited_nodes.append(u)

    paths = {}
    for node in graph.nodes:
        path = []
        if node != source:
            path.append(source)
        n = prev[node]
        while n != node and n != source:
            path.append(n)
            n = prev[n]
        path.append(node)
        paths[node] = path
        sorted_items = sorted(paths.items(), key=lambda item: len(item[1]))
        newd = dict(sorted_items)
    return newd, prev


if __name__ == "__main__":
    print("Shortest Path - Dijkstra Alg.")
    print(" ")
    n_nodes = int(input("Num de Nodes: "))
    source = int(input("Source Node: "))
    G = nx.complete_graph(n_nodes)
    for (u, v) in G.edges():
        G.edges[u, v]['weight'] = random.randint(1, 15)

    my_path = shortest_path(G, source=source)
    print(" ")
    print(f"Os melhores caminhos são: {my_path[0]}")
    pos = nx.spring_layout(G)
    nx.draw(G, pos, with_labels=True,node_color='#bfbfbf')
    nx.draw(G, pos, nodelist={source}, edgelist=my_path[1].items(), node_color='#f69112', edge_color='#ff4040', width=2,
            edge_cmap=plt.cm.Blues,
            with_labels=True)

    labels = nx.get_edge_attributes(G, 'weight')
    nx.draw_networkx_edge_labels(G, pos, edge_labels=labels)
    plt.show()
