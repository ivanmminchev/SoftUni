class Team:
    def __init__(self, name, rating):
        self.__name = name
        self.__rating = rating
        self.__players = []

    def add_player(self, player):
        if player in self.__players:
            return f"Player {player.name} has already joined"
        self.__players.append(player)
        return f"Player {player.name} joined team {self.__name}"

    def remove_player(self, player_name):
        filltered_players = [x for x in self.__players if x.name == player_name]
        if filltered_players:
            player = filltered_players[0]
            self.__players.remove(filltered_players[0])
            return player
        return f"Player {player_name} not found"