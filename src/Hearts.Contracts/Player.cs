namespace Hearts.Contracts;

public record Player(Guid Id, string PlayerName, bool IsBot = false);
