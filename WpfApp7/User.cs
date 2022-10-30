using System;

namespace WpfApp7;

#nullable disable

public class User
{
	public Guid Id { get; set; } = Guid.NewGuid();
	public string Firstname { get; set; }
	public string Lastname { get; set; }
	public string Gender { get; set; }
	public string Phone { get; set; }
	public string ImageUrl { get; set; }
	public string Email { get; set; }
	public string Address { get; set; }
	public DateTime DateOfBirth { get; set; }
}