using EventEaseApp.Data.Models;

namespace EventEaseApp.Services;

public interface IEventService
{
    List<Event> GetList();
    Event GetById(int Id);
    void Add(Event eventObj);
    void AddAttendee(int eventId, int userId);
}

public class EventService : IEventService
{
    private static List<Event> Events { get; set; }

    public EventService()
    {
        Events = new List<Event>
            {
                new Event
                {
                    Id = 1,
                    Name = "AI Innovation Summit",
                    Date = new DateTime(2025, 5, 15),
                    Location = "Tech Hub, Seattle",
                    Description = "Join industry leaders for a day of discussions on the latest AI advancements and practical applications across various sectors.",
                    TicketPrice = 299.99m
                },
                new Event
                {
                    Id = 2,
                    Name = "Spring Jazz Festival",
                    Date = new DateTime(2025, 4, 12),
                    Location = "Waterfront Park, New Orleans",
                    Description = "Experience the smooth sounds of jazz with performances by both renowned and emerging artists in the birthplace of jazz.",
                    TicketPrice = 85.50m
                },
                new Event
                {
                    Id = 3,
                    Name = "Global Cybersecurity Conference",
                    Date = new DateTime(2025, 6, 22),
                    Location = "Convention Center, Washington DC",
                    Description = "Learn about the latest threats, defense strategies, and regulatory compliance from cybersecurity experts and government officials.",
                    TicketPrice = 450.00m
                },
                new Event
                {
                    Id = 4,
                    Name = "International Food Festival",
                    Date = new DateTime(2025, 7, 8),
                    Location = "Central Plaza, Chicago",
                    Description = "Taste cuisine from over 30 countries, watch cooking demonstrations, and participate in food workshops throughout this weekend event.",
                    TicketPrice = 40.00m
                },
                new Event
                {
                    Id = 5,
                    Name = "Sustainable Living Expo",
                    Date = new DateTime(2025, 5, 28),
                    Location = "Green Convention Center, Portland",
                    Description = "Discover eco-friendly products, attend sustainability workshops, and learn how to reduce your carbon footprint from environmental experts.",
                    TicketPrice = 25.75m
                },
                new Event
                {
                    Id = 6,
                    Name = "Summer Beach Volleyball Tournament",
                    Date = new DateTime(2025, 7, 18),
                    Location = "Ocean Beach, San Diego",
                    Description = "Watch professional volleyball players compete for the championship title on the scenic beaches of Southern California.",
                    TicketPrice = 30.00m
                },
                new Event
                {
                    Id = 7,
                    Name = "Modern Art Exhibition",
                    Date = new DateTime(2025, 9, 5),
                    Location = "Contemporary Art Museum, New York",
                    Description = "Experience groundbreaking works from emerging artists challenging conventional perspectives through various media and installations.",
                    TicketPrice = 22.50m
                },
                new Event
                {
                    Id = 8,
                    Name = "Financial Investment Workshop",
                    Date = new DateTime(2025, 4, 25),
                    Location = "Financial District, Boston",
                    Description = "Learn investment strategies from financial advisors and gain insights into market trends, retirement planning, and wealth management.",
                    TicketPrice = 150.00m
                },
                new Event
                {
                    Id = 9,
                    Name = "Indie Film Showcase",
                    Date = new DateTime(2025, 10, 12),
                    Location = "Arts Theater, Austin",
                    Description = "Discover the next generation of filmmakers with screenings of selected independent films from around the world, followed by director Q&As.",
                    TicketPrice = 35.00m
                },
                new Event
                {
                    Id = 10,
                    Name = "Digital Marketing Masterclass",
                    Date = new DateTime(2025, 6, 9),
                    Location = "Business Center, San Francisco",
                    Description = "Enhance your marketing skills with expert-led sessions on SEO, social media strategy, content marketing, and analytics.",
                    TicketPrice = 225.99m
                },
                new Event
                {
                    Id = 11,
                    Name = "Health & Wellness Fair",
                    Date = new DateTime(2025, 8, 16),
                    Location = "Community Center, Denver",
                    Description = "Focus on your wellbeing with health screenings, fitness demonstrations, nutrition talks, and wellness product showcases.",
                    TicketPrice = 15.00m
                },
                new Event
                {
                    Id = 12,
                    Name = "Classic Car Show",
                    Date = new DateTime(2025, 7, 29),
                    Location = "Exhibition Grounds, Detroit",
                    Description = "View rare and beautifully restored vintage automobiles spanning decades of automotive history with expert commentary and owner stories.",
                    TicketPrice = 45.00m
                },
                new Event
                {
                    Id = 13,
                    Name = "Agricultural Fair",
                    Date = new DateTime(2025, 9, 18),
                    Location = "County Fairgrounds, Des Moines",
                    Description = "Celebrate rural traditions with livestock exhibits, farming demonstrations, produce competitions, and family-friendly entertainment.",
                    TicketPrice = 18.50m
                },
                new Event
                {
                    Id = 14,
                    Name = "Comic & Gaming Convention",
                    Date = new DateTime(2025, 11, 2),
                    Location = "Mega Convention Center, Atlanta",
                    Description = "Meet your favorite creators, play new game releases, participate in cosplay contests, and join panel discussions on pop culture.",
                    TicketPrice = 65.00m
                },
                new Event
                {
                    Id = 15,
                    Name = "Children's Science Day",
                    Date = new DateTime(2025, 6, 15),
                    Location = "Science Museum, Houston",
                    Description = "Engage young minds with interactive science exhibits, fun experiments, robotics demonstrations, and educational presentations.",
                    TicketPrice = 12.00m
                },
                new Event
                {
                    Id = 16,
                    Name = "International Dance Festival",
                    Date = new DateTime(2025, 10, 25),
                    Location = "Performing Arts Center, Miami",
                    Description = "Experience dance traditions from cultures around the world through professional performances, workshops, and cultural exhibitions.",
                    TicketPrice = 50.00m
                },
                new Event
                {
                    Id = 17,
                    Name = "Craft Beer & Spirits Tasting",
                    Date = new DateTime(2025, 8, 8),
                    Location = "Waterfront Brewery, Milwaukee",
                    Description = "Sample selections from over 100 local and international breweries and distilleries, paired with artisanal food offerings.",
                    TicketPrice = 75.00m
                },
                new Event
                {
                    Id = 18,
                    Name = "Mountain Biking Championship",
                    Date = new DateTime(2025, 9, 27),
                    Location = "Mountain Trails, Colorado Springs",
                    Description = "Watch elite mountain bikers compete on challenging terrain in both downhill and cross-country events against stunning mountain backdrops.",
                    TicketPrice = 35.75m
                },
                new Event
                {
                    Id = 19,
                    Name = "Authors & Book Festival",
                    Date = new DateTime(2025, 5, 10),
                    Location = "Central Library, Philadelphia",
                    Description = "Meet bestselling authors, attend book signings, participate in writing workshops, and discover new titles from emerging writers.",
                    TicketPrice = 20.00m
                },
                new Event
                {
                    Id = 20,
                    Name = "Renewable Energy Symposium",
                    Date = new DateTime(2025, 6, 28),
                    Location = "Green Tech Center, Phoenix",
                    Description = "Learn about the latest innovations in solar, wind, and other renewable energy technologies from industry pioneers and researchers.",
                    TicketPrice = 175.50m
                }
            };
    }

    public List<Event> GetList()
    {
        return Events;
    }

    public Event GetById(int Id)
    {
        return Events?.Where(x => x.Id == Id).FirstOrDefault();
    }

    public void Add(Event eventObj)
    {
        Events.Add(eventObj);
    }

    public void AddAttendee(int eventId, int userId)
    {
        var selectedEvent = Events.Where(x => x.Id == eventId).FirstOrDefault();
        selectedEvent?.AttendeeIds.Add(userId);
    }
}