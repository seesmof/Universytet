## Лаба 4 - 11.05.2023 09:15

- [ ] Завдання 1
  - [ ] Задача 1
  - [ ] Задача 2
- [x] Завдання 2

---

## Завдання 1

### 1. За допомогою y-алгоритма зробити укладку графа у площині, або довести що вона неможлива

### 2. Побудувати повний потік, а потім скорегувати його до найбільшого (дуги спрямовані зліва направо)

## Завдання 2

### Написати програму, яка знаходить максимальний потік в мережі. Протестувати зробленою програмою мережу із завдання #1, задача 2

Цю задачу можна вирішити за допомогою алгоритму форда фалкерсона

```py
import networkx as nx


def create_graph():
    G = nx.DiGraph()
    nodes = ['1', '2', '3', '4', '5', '6',
             '7', '8', '9', '10', '11', '12', '13']
    edges = [('1', '2', 11), ('1', '3', 15), ('1', '4', 11), ('1', '5', 15), ('2', '6', 7), ('2', '7', 9), ('3', '6', 4), ('4', '7', 8), ('4', '8', 9), ('4', '9', 4), ('5', '8', 9),
             ('5', '9', 5), ('6', '10', 8), ('7', '10', 13), ('7', '11', 7), ('8', '11', 4), ('8', '12', 4), ('9', '12', 12), ('10', '13', 20), ('11', '13', 10), ('12', '13', 13)]
    G.add_nodes_from(nodes)
    for edge in edges:
        G.add_edge(edge[0], edge[1], capacity=edge[2])
    return G


G = create_graph()

max_flow_value = nx.maximum_flow(G, '1', '13')

print()
print("Потік:")
for edge in G.edges():
    edge_str = edge[0] + " - " + edge[1] + " -- " + \
        str(G.get_edge_data(edge[0], edge[1])['capacity'])
    print(edge_str)


print("\nМаксимальний потік:", max_flow_value)
print()
```