Listing
  type: private OR flat OR new 
  owner: User

  viewDetails()
  editDetails()
  deleteListing()
  addListing()
User 
  manager: bool
  meetings: list[Meeting]
  listings: list[Listing]
  chosen: list[Listing]

  viewDetails()
  editDetails()
  viewListings()
  viewChosenListings()
  viewMeetings()
Meeting 
  status: pending OR visited OR canceled
  score: int 1 to 10
  listing: Listing

  scheduleMeeting()
  viewDetails()
  editDetails()
  rateMeeting()

confirmMeeting(): Meeting.status=visited
viewAllMeetings(): return list[Meeting] Meeting.listing.owner==current_user__owner
viewChosenMeetings(): return [Listing for Listing in viewAllMeetings() if Listing in current_user__owner.chosen]
cancelMeeting(): Meeting.status=canceled
editListing(newListingData: Listing): Listing=newListingData